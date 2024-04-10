using Employees.Core.Entites;
using Employees.Core.Repositories;
using Employees.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;
        private readonly ICompanyTermsRepository _termsRepository;

        public CompanyService(ICompanyRepository repository, ICompanyTermsRepository termsRepository)
        {
            _repository = repository;
            _termsRepository = termsRepository;
        }

        public async Task<Company> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<Company> UpdateCompanyDetailsAsync(int id, Company company)
        {
            string patternEmail = "^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$";
            var regexEmail = new Regex(patternEmail);
            if (company != null && company.Name != null && company.Name != "" &&
                company.Email != null && regexEmail.Match(patternEmail).Success &&
                company.Address != null && company.Address != "")
                return await _repository.UpdateCompanyDetailsAsync(id, company);
            return null;
        }

        public async Task<Company> UpdateUserNamePasswordAsync(int id, string userName, string password)
        {
            string patternPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$";
            var regexPassword = new Regex(patternPassword);
            if (userName != null && userName != "" &&
                password != null && regexPassword.Match(patternPassword).Success)
                return await _repository.UpdateUserNamePasswordAsync(id, userName, password);
            return null;
        }

        public async Task<Company> ChangeManagerAsync(int id, int managerId)
        {
            if (id > 0 && managerId > 0)
                return await _repository.ChangeManagerAsync(id, managerId);
            return null;
        }

        public async Task<Company> DeleteCompanyAsync(int id)
        {
            if (id > 0)
                return await _repository.DeleteCompanyAsync(id);
            return null;
        }

    }
}
