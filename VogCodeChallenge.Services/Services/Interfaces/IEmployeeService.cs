using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Models;

namespace VogCodeChallenge.Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IEnumerable<Employee> GetByDepartment(long departmentId);

        Task<IEnumerable<Employee>> GetAllDb();
        Task<IList<Employee>> ListAllDb();
        Task<IEnumerable<Employee>> GetByDepartmentDb(long departmentId);
    }
}
