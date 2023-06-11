using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using eWellness.DL;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class ClientService : IClientService
    {
        protected IClientRepository _clientRepository { get; set; }

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public ValueTask<EntityEntry<Client>> AddAsync(Client entity)
        {
            return _clientRepository.AddAsync(entity);
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

        public Task<Client> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _clientRepository.GetByIdAsync(id, asNoTracking);
        }

        public Task<List<Client>> FilterAsync(BaseFilterParameters parameters)
        {
            return _clientRepository.Filter(parameters);
        }

        public void Attach(Client entity)
        {
            _clientRepository.Attach(entity);
        }
    }
}
