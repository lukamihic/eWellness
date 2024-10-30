using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.Cryptography;

namespace eWellness.BL
{
    public class UserService : IUserService
    {
        protected IUserRepository _userRepository { get; set; }

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ValueTask<EntityEntry<User>> AddAsync(User entity)
        {
            var password = HashPassword(entity.PasswordInput);
            entity.PasswordHash = password[0];
            entity.PasswordSalt = password[1];

            return _userRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<User> entities)
        {
            return _userRepository.AddRangeAsync(entities);
        }

        public void Remove(User entity)
        {
            _userRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<User> entities)
        {
            _userRepository.RemoveRange(entities);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<User> entities)
        {
            _userRepository.UpdateRange(entities);
        }

        public async Task<User> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var user = await _userRepository.GetByIdAsync(id, asNoTracking);
            
            user.PasswordHash = null;
            user.PasswordSalt = null;

            return user;
        }

        public void Attach(User entity)
        {
            _userRepository.Attach(entity);
        }

        public async Task<int> Login(string email, string password)
        {
            var user = (await _userRepository.Filter(null)).FirstOrDefault(u => u.Email == email && !u.IsDeleted);
            if(user != null)
            {
                if (VerifyPassword(user.PasswordHash, password))
                    return user.Id;
                return -1;
            } 
            else
            {
                return -1;
            }
        }

        //helper methods
        private static List<string> HashPassword(string password)
        {
            // Generate a salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create the Rfc2898DeriveBytes and get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            string saltString = Convert.ToBase64String(salt);

            return new List<string>() { savedPasswordHash, saltString };
        }
        private static bool VerifyPassword(string savedPasswordHash, string password)
        {
            // Extract the bytes
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            // Get the salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compare the results
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
