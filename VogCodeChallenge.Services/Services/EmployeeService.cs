using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Models;
using VogCodeChallenge.Infrastructure;
using VogCodeChallenge.Infrastructure.DB.Repositories.Interfaces;
using VogCodeChallenge.Services.Services.Interfaces;

namespace VogCodeChallenge.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeesRepository _employeeRepository;
        private readonly DataSupplier _dataSupplier;

        public EmployeeService(IEmployeesRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
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

        public IEnumerable<Employee> GetByDepartment(long departmentId)
        {
            return _dataSupplier.GetEmployeesByDepartment(departmentId);
        }

        public async Task<IEnumerable<Employee>> GetAllDb()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task<IList<Employee>> ListAllDb()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task<IEnumerable<Employee>> GetByDepartmentDb(long departmentId)
        {
            return await _employeeRepository.GetEmployeesByDepartment(departmentId);
        }

    }
}
