using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
