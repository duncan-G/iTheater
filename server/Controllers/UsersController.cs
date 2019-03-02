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
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Server.Dtos;
using Server.Helpers;
using Server.Models;
using Server.Services;

namespace Server.Controllers {
    [Authorize]
    [Route ("auth/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        private IMapper _entityDtoMapper;
        private readonly AppSettings _appSettings;
        private IUserService _userService;

        public UsersController (
            IUserService userService,
            IOptions<AppSettings> appSettings,
            IMapper mapper) {
            _userService = userService;
            _appSettings = appSettings.Value;
            _entityDtoMapper = mapper;

        }

        // /auth/users/login
        [AllowAnonymous]
        [HttpPost ("login")]
        public async Task<ActionResult<User>> Login ([FromBody] UserDto userDto) {
            var user = await _userService.Authenticate (userDto.email, userDto.password);

            if (user == null) {
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
                await _userService.Create(user, userDto.password);

                var tokenString = AcquireJwtToken (user);
                return Ok (new {
                    id = user.Id,
                        email = user.Email,
                        token = tokenString
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
    }
}