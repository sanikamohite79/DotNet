using HRAsyncWebApi.Models;

namespace HRAsyncWebApi.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Emp>> GetAllAsync();
        Task<Emp?> GetByIdAsync(int id);
        Task AddAsync(Emp employee);
    }
}