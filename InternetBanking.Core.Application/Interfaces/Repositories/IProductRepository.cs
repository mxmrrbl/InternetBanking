
using InternetBanking.Core.Domain.Entities;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Products>
    {
        Task<bool> ExistAync(int Code);
        Task<Products> GetByIdAsync(string id);
        
    }
}
