using eWellness.BL.Common;
using eWellness.Core.Common.Models;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.Cryptography;

namespace eWellness.BL
{
    public class ClientService : IClientService
    {
        protected IClientRepository _clientRepository { get; set; }
        protected IRabbitMQProducer _rabbitMQProducer { get; set; }

        public ClientService(IClientRepository clientRepository, IRabbitMQProducer rabbitMQProducer)
        {
            _clientRepository = clientRepository;
            _rabbitMQProducer = rabbitMQProducer;
        }

        public ValueTask<EntityEntry<Client>> AddAsync(Client entity)
        {
            var password = HashPassword(entity.User.PasswordInput);
            entity.User.PasswordHash = password[0];
            entity.User.PasswordSalt = password[1];

            var client = _clientRepository.AddAsync(entity);
            try
            {
                _rabbitMQProducer.SendEmailMessage(entity, Core.Enums.MailTypeEnum.NewUser);
            }catch (Exception e)
            {

            }


            return client;
        }

        public Task AddRangeAsync(IEnumerable<Client> entities)
        {
            return _clientRepository.AddRangeAsync(entities);
        }

        public void Remove(Client entity)
        {
            _clientRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Client> entities)
        {
            _clientRepository.RemoveRange(entities);
        }

        public void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Client> entities)
        {
            _clientRepository.UpdateRange(entities);
        }

        public async Task<Client> GetByIdAsync(int id, bool asNoTracking = false)
        {
            var client = await _clientRepository.GetByIdAsync(id, asNoTracking);
            if (client.User != null) {
                client.User.PasswordHash = null;
                client.User.PasswordSalt = null;
            }
            return client;
        }

        public Task<List<Client>> FilterAsync(BaseFilterParameters parameters)
        {
            return _clientRepository.Filter(parameters);
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

        public void Attach(Client entity)
        {
            _clientRepository.Attach(entity);
        }
    }
}
