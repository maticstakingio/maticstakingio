using Core.Data.Entities;
using Core.Infrastructure.Interfaces;
using System;

namespace Core.Data.IRepositories
{

    public interface ISystemTransactionRepository : IRepository<SystemTransaction, int>
    {
        public bool ProcessDepositToRegularWallet(Guid appUserId, decimal amount);
    }
}
