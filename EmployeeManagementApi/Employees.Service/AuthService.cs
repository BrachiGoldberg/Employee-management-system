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
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }


        public async Task<Company> Login(string userName, string password)
        {
            if (userName == null && password == null)
                return await _repository.Login(userName, password);
            return null;
        }

        public async Task<Company> RegisterAsync(Company company)
        {
            string patternEmail = "^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$";
            var regexEmail = new Regex(patternEmail);
            string patternPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$";
            var regexPassword = new Regex(patternPassword);
            if (company != null && 
                company.Name != null && company.Name != "" &&
                company.Email != null && regexEmail.Match(company.Email).Success &&
                company.UserName != null && company.UserName != "" &&
                company.Password != null && company.Password != "" && regexPassword.Match(company.Password).Success &&
                company.Address != null && company.Address != "")
                return await _repository.RegisterAsync(company);
            return null;
        }
    }
}
