﻿using Employees.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Core.Services
{
    public interface ICompanyService
    {
        public Task<Company> GetAsync(int id);

        public Task<Company> UpdateCompanyDetailsAsync(int id, Company company);

        public Task<Company> UpdateUserNamePasswordAsync(int id, string userName, string password);

        public Task<Company> ChangeManagerAsync(int id, int managerId);

        public Task<Company> DeleteCompanyAsync(int id);
    }
}
