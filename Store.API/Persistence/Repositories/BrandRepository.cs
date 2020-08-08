using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.API.Domain.Models;
using Store.API.Domain.Repositories;
using Store.API.Persistence.Contexts;

namespace Store.API.Persistence.Repositories
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {

        }

        public async Task AddAsync(Brand brand)
        {
            await context.Brands.AddAsync(brand);
        }

        public async Task<IEnumerable<Brand>> ListAsync()
        {
            return await context.Brands.ToListAsync();
        }

        
    }
}