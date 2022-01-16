using System.Collections.Generic;
using VogCodeChallenge.Domain.Models;
using System.Linq;

namespace VogCodeChallenge.Infrastructure
{
    public class DataSupplier
    {

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            { 
                new Employee(){ 
                    Id = 1,
                    FirstName = "Marcos",
                    LastName = "Jeeves",
                    JobTitle = "Product Owner",
                    MailingAddress = "4323 Robson St, Vancouver BC V6B 3K9",
                    DepartmentId = 1
                },
                new Employee(){
                    Id = 2,
                    FirstName = "Miriam",
                    LastName = "Belmont",
                    JobTitle = "Web Developer",
                    MailingAddress = "4279 Tolmie St, Vancouver BC  V6M 1Y8",
                    DepartmentId = 1
                },
                new Employee(){
                    Id = 3,
                    FirstName = "Sam",
                    LastName = "Aran",
                    JobTitle = "Human Resources Analyst",
                    MailingAddress = "2108 St George Street, Vancouver BC V5T 1Z7",
                    DepartmentId = 2
                }
            };
        }

        public List<Employee> GetEmployeesByDepartment(long deparmentId)
        {
            return GetEmployees().Where(e => e.DepartmentId == deparmentId).ToList();
        }
    }    
}
