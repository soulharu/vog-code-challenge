using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using VogCodeChallenge.Domain.Models;
using VogCodeChallenge.Infrastructure.DB.Connection;
using VogCodeChallenge.Infrastructure.DB.Repositories.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace VogCodeChallenge.Infrastructure.DB.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private IConnectionFactory _connectionFactory;
        private ILogger<EmployeesRepository> _logger;

        public EmployeesRepository(IConnectionFactory connectionFactory, ILogger<EmployeesRepository> logger)
        {
            _connectionFactory = connectionFactory;
            _logger = logger;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                var sqlCommand = "SELECT * FROM dbo.Employees";

                using (var db = _connectionFactory.Get(ConnectionNames.ApplicationSQL))
                {
                    var result = await db.QueryAsync<Employee>(sql: sqlCommand, commandType: CommandType.Text);
                    employees = result.ToList();
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Database Error when calling EmployeesRepository.GetEmployees method. {ex.Message}");
            }

            return employees;
        }

        public async Task<List<Employee>> GetEmployeesByDepartment(long departmentId)
        {
            var employees = new List<Employee>();

            try
            {
                var sqlCommand = "SELECT * FROM dbo.Employees WHERE DepartmentId = @departmentId";

                var parameters = new DynamicParameters();
                parameters.Add("@departmentId", departmentId, DbType.Int64);

                using (var db = _connectionFactory.Get(ConnectionNames.ApplicationSQL))
                {
                    var result = await db.QueryAsync<Employee>(sql: sqlCommand, param: parameters, commandType: CommandType.Text);
                    employees = result.ToList();
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Database Error when calling EmployeesRepository.GetEmployeesByDepartment method. {ex.Message}");
            }

            return employees;
        }
    }
}
