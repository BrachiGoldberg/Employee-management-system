using Employees.Core.Entites;
using Employees.Core.Repositories;
using Employees.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository _repository;

        public BankAccountService(IBankAccountRepository repository)
        {
            _repository = repository;
        }



        public Task<BankAccount> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<BankAccount> AddAsync(BankAccount bankAccount)
        {
            if (bankAccount != null && bankAccount.Id != 0
                && bankAccount.BankAccountNumber != 0 && bankAccount.BranchNumber != 0
                && bankAccount.BankNunber != 0)
                return _repository.AddAsync(bankAccount);
            return null;
        }

        public Task<BankAccount> UpdateAsync(int id, BankAccount bankAccount)
        {
            if (bankAccount != null && bankAccount.Id != 0
                && bankAccount.BankAccountNumber != 0 && bankAccount.BranchNumber != 0
                && bankAccount.BankNunber != 0)
                return _repository.UpdateAsync(id, bankAccount);
            return null;
        }

        public Task<BankAccount> DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

    }
}
