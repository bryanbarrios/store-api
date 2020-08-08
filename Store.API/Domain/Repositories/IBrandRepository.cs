using System.Collections.Generic;
using System.Threading.Tasks;
using Store.API.Domain.Models;

namespace Store.API.Domain.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> ListAsync();
        Task AddAsync(Brand brand);
    }
}