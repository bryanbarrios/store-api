using System.Collections.Generic;
using System.Threading.Tasks;
using Store.API.Domain.Models;
using Store.API.Domain.Services.Communication;

namespace Store.API.Domain.Services
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> ListAsync();
        Task<SaveBrandResponse> SaveAsync(Brand brand);
    }   
}