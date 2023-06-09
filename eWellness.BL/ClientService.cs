﻿using eWellness.BL.Common;
using eWellness.Core.Models;
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

        public virtual ValueTask<EntityEntry<Client>> AddAsync(Client entity)
        {
            return _clientRepository.AddAsync(entity);
        }

        public virtual Task AddRangeAsync(IEnumerable<Client> entities)
        {
            return _clientRepository.AddRangeAsync(entities);
        }

        public virtual void Remove(Client entity)
        {
            _clientRepository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<Client> entities)
        {
            _clientRepository.RemoveRange(entities);
        }

        public virtual void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<Client> entities)
        {
            _clientRepository.UpdateRange(entities);
        }

        public virtual Task<Client> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _clientRepository.GetByIdAsync(id, asNoTracking);
        }

        public virtual void Attach(Client entity)
        {
            _clientRepository.Attach(entity);
        }
    }
}