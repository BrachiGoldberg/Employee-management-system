﻿using Employees.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Core.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll(int companyId);

        public Task<Employee> GetByIdAsync(int id);

        public Task<Employee> AddNewAsync(Employee employee);

        public Task<Employee> UpdateAsync(int id, Employee employee);

        public Task<Employee> UpdateStatusAsync(int id);

        public Task<Employee> UpadtePositionsToEmployeeAsync(int id, List<EmployeePosition> positionsId);

        //public Task<Employee> AddPositionAsync(int id, int positionId);

        //public Task<Employee> RemovePositionAsync(int id, int positinId);

        public Task<Employee> DeleteFromDbAsync(int id);

    }
}
