﻿using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.DL.Common;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eWellness.BL
{
    public class InvoiceService : IInvoiceService
    {
        protected IInvoiceRepository _invoiceRepository { get; set; }

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public ValueTask<EntityEntry<Invoice>> AddAsync(Invoice entity)
        {
            return _invoiceRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<Invoice> entities)
        {
            return _invoiceRepository.AddRangeAsync(entities);
        }

        public void Remove(Invoice entity)
        {
            _invoiceRepository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Invoice> entities)
        {
            _invoiceRepository.RemoveRange(entities);
        }

        public void Update(Invoice entity)
        {
            _invoiceRepository.Update(entity);
        }

        public void UpdateRange(IEnumerable<Invoice> entities)
        {
            _invoiceRepository.UpdateRange(entities);
        }

        public Task<Invoice> GetByIdAsync(int id, bool asNoTracking = false)
        {
            return _invoiceRepository.GetByIdAsync(id, asNoTracking);
        }

        public void Attach(Invoice entity)
        {
            _invoiceRepository.Attach(entity);
        }
    }
}
