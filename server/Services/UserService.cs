using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Dtos;
using Server.Helpers;
using Server.Models;

namespace Server.Services {

    public interface IUserService {
        Task<User> Authenticate (string username, string password);
        Task<User> Create (User user, string password);
    }

    public class UserService : IUserService {
        private DataContext _context;

        public UserService (DataContext context) {
            _context = context;
        }

        public async Task<User> Authenticate (string email, string password) {
            if (string.IsNullOrEmpty (email) || string.IsNullOrEmpty (password))
                return null;

            var user = await _context.Users.SingleOrDefaultAsync (_user => _user.Email == email);

            if (!GeneralHelpers.VerifyPasswordHash (password, user.PasswordHash, user.Salt)) {
                return null;
            }

            return user;
        }

        public async Task<User> Create (User user, string password) {
            if (string.IsNullOrWhiteSpace (password))
                throw new AppException ("Password is required!");

            if (await _context.Users.AnyAsync (_user => _user.Email == user.Email))
                throw new AppException ("Email already exists!");

            byte[] passwordHash, passwordSalt;
            GeneralHelpers.CreatePasswordHash (password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.Salt = passwordSalt;

            await _context.Users.AddAsync (user);
            await _context.SaveChangesAsync ();

            return user;
        }
    }
}