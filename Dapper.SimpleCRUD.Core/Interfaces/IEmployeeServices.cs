using Dapper.SimpleCRUD.Core.Models;

namespace Dapper.SimpleCRUD.Core.Interfaces
{
    public interface IEmployeeServices
    {
        Task<IList<Employee>> GetAllDataAsync();
        Task<int> InsertDataAsync(Employee obj);
        Task<int> UpdateDataAsync(Employee obj);
        Task<int> DeleteDataAsync(int id);
        Task<Employee> GetDataByIdAsync(int id);
    }
}
