using Dapper.SimpleCRUD.Core.Interfaces;
using Dapper.SimpleCRUD.Core.Models;
using System.Data.SqlClient;

namespace Dapper.SimpleCRUD.Core.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly string _connectionString = "Server=.;Database=SingleCRUD.DB;Integrated Security=true; TrustServerCertificate=True;";
        public async Task<IList<Employee>> GetAllDataAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var objects = await connection.GetListAsync<Employee>();
            return objects.ToList();
        }

        public async Task<int> InsertDataAsync(Employee obj)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            var id = await connection.InsertAsync(obj);
            return (int)id;
        }
        public async Task<int> UpdateDataAsync(Employee obj)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            return await connection.UpdateAsync(obj);
        }
        public async Task<int> DeleteDataAsync(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            return await connection.DeleteAsync<Employee>(id);
        }
        public async Task<Employee> GetDataByIdAsync(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            return await connection.GetAsync<Employee>(id);
        }
    }
}
