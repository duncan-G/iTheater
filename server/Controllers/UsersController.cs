using System;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using Server.Dtos;
using Server.Helpers;
using Server.Models;

namespace Server.Controllers {
    [Authorize]
    [Route ("auth/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        private readonly DataContext _context;
        private IMapper _entityDtoMapper;
        private readonly AppSettings _appSettings;

        public UsersController (
            DataContext context,
            IOptions<AppSettings> appSettings,
            IMapper mapper) {
            _context = context;
            _appSettings = appSettings.Value;
            _entityDtoMapper = mapper;

        }

        // /auth/users/login
        [AllowAnonymous]
        [HttpPost ("login")]
        public async Task<ActionResult<User>> Login ([FromBody] UserDto userDto) {
            var user = await _context.Users.SingleOrDefaultAsync (_user => _user.Email == userDto.email);

            if (user == null) {
                return BadRequest (new { message = "Username or Password is incorrect." });
            }

            if (!VerifyPasswordHash (userDto.password, user.PasswordHash, user.Salt)) {
                return BadRequest (new { message = "Username or Password is incorrect." });
            }

            var tokenString = AcquireJwtToken (user);

            return Ok (new {
                id = user.Id,
                    email = user.Email,
                    token = tokenString
            });
        }

        // /auth/users/register
        [AllowAnonymous]
        [HttpPost ("register")]
        public async Task<ActionResult<User>> Register ([FromBody] UserDto userDto) {
            // map dto to entity
            var user = _entityDtoMapper.Map<User> (userDto);

            try {
                if (await _context.Users.AnyAsync (_user => _user.Email == user.Email)) {
                    return BadRequest (new { message = "Email already exists!" });
                }

                byte[] passwordHash, passwordSalt;
                CreatePasswordHash (userDto.password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.Salt = passwordSalt;

                await _context.Users.AddAsync (user);
                await _context.SaveChangesAsync ();

                var tokenString = AcquireJwtToken (user);
                return Ok (new {
                    Id = user.Id,
                        Email = user.Email,
                        Token = tokenString
                });

            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

        private string AcquireJwtToken (User user) {
            var jwtTokenHandler = new JwtSecurityTokenHandler ();
            var key = Encoding.ASCII.GetBytes (_appSettings.JwtSecret);
            var jwtTokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity (new Claim[] {
                new Claim (ClaimTypes.Name, user.Id.ToString ())
                }),
                Expires = DateTime.UtcNow.AddDays (14),
                SigningCredentials = new SigningCredentials (new SymmetricSecurityKey (key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = jwtTokenHandler.CreateToken (jwtTokenDescriptor);
            var tokenString = jwtTokenHandler.WriteToken (token);
            return tokenString;
        }

        private static void CreatePasswordHash (string password, out byte[] passwordHash, out byte[] salt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512 ()) {
                salt = hmac.Key;
                passwordHash = hmac.ComputeHash (System.Text.Encoding.UTF8.GetBytes (password));
            }
        }

        private static bool VerifyPasswordHash (string password, byte[] storedHash, byte[] storedSalt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512 (storedSalt)) {
                var computedHash = hmac.ComputeHash (System.Text.Encoding.UTF8.GetBytes (password));
                for (int i = 0; i < computedHash.Length; i++) {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }
    }
}