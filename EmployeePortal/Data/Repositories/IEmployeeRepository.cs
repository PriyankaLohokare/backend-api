﻿using EmployeePortal.Models;

namespace EmployeePortal.Data.Repositories
{

        public interface IEmployeeRepository
        {
            Task<IEnumerable<Employee>> GetEmployeesAsync();
            Task<Employee> GetEmployeeByIdAsync(int id);
            Task AddEmployeeAsync(Employee employee);
            Task UpdateEmployeeAsync(Employee employee);
            Task DeleteEmployeeAsync(int id);
        }
}

