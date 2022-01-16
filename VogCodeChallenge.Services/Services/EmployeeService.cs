using System;
using System.Collections.Generic;
using VogCodeChallenge.Domain.Models;
using VogCodeChallenge.Infrastructure;
using VogCodeChallenge.Services.Services.Interfaces;

namespace VogCodeChallenge.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataSupplier _dataSupplier;

        public EmployeeService()
        {
            _dataSupplier = new DataSupplier();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dataSupplier.GetEmployees();
        }

        public IList<Employee> ListAll()
        {
            return _dataSupplier.GetEmployees();
        }
    }
}
