using System.Collections.Generic;
using VogCodeChallenge.Domain.Models;

namespace VogCodeChallenge.Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
