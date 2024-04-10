using Employees.Core.Entites;
using Employees.Core.Repositories;
using Employees.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employees.Service
{
    public class EmployeeService : IEmployeeSerivce
    {
        private readonly IEmployeeRepository _repository;
        private readonly string _patternEmail = "^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,}$";

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Employee> GetAll(int companyId)
        {
            return _repository.GetAll(companyId);
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Employee> AddNewAsync(Employee employee)
        {

            var regexEmail = new Regex(_patternEmail);
            string patternIdentity = "^[\\d]{9}$";
            var regexIdentity = new Regex(patternIdentity);
            if (employee != null &&
                employee.FirstName != null && employee.FirstName != "" &&
                employee.LastName != null && employee.LastName != "" &&
                employee.Address != null && employee.Address != "" &&
                employee.Email != null && regexEmail.Match(employee.Email).Success &&
                employee.Identity != null && regexIdentity.Match(employee.Identity).Success &&
                employee.StartJob > employee.BirthDate)
                return await _repository.AddNewAsync(employee);
            return null;
        }

        public async Task<Employee> UpdateAsync(int id, Employee employee)
        {
            var regexEmail = new Regex(_patternEmail);
            if (employee != null &&
                employee.FirstName != null && employee.FirstName != "" &&
                employee.LastName != null && employee.LastName != "" &&
                employee.Address != null && employee.Address != "" &&
                employee.Email != null && regexEmail.Match(employee.Email).Success)
                return await _repository.UpdateAsync(id, employee);
            return null;
        }

        public async Task<Employee> UpdateStatusAsync(int id)
        {
            return await _repository.UpdateStatusAsync(id);
        }

        public async Task<Employee> UpadtePositionsToEmployeeAsync(int id, List<EmployeePosition> positions)
        {
            return await _repository.UpadtePositionsToEmployeeAsync(id, positions);
        }

        public async Task<Employee> DeleteFromDbAsync(int id)
        {
            return await _repository.DeleteFromDbAsync(id);
        }
    }
}
