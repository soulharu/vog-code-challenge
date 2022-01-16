using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Models;

namespace VogCodeChallenge.Infrastructure.DB.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<List<Employee>> GetEmployeesByDepartment(long departmentId);
    }
}
