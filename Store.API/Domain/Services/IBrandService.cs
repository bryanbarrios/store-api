using System.Collections.Generic;
using System.Threading.Tasks;
using Store.API.Domain.Models;

namespace Store.API.Domain.Services
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> ListAsync();
    }   
}