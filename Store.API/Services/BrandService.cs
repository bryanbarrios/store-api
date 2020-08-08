using System.Collections.Generic;
using System.Threading.Tasks;
using Store.API.Domain.Models;
using Store.API.Domain.Repositories;
using Store.API.Domain.Services;
using Store.API.Domain.Services.Communication;

namespace Store.API.Services
{
    public class BrandService : IBrandService 
    {
        private readonly IBrandRepository brandRepository;
        private readonly IUnitOfWork unitOfWork;

        public BrandService(IBrandRepository brandRepository, IUnitOfWork unitOfWork) {
            this.brandRepository = brandRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Brand>> ListAsync()
        {
            return await brandRepository.ListAsync();
        }

        public async Task<SaveBrandResponse> SaveAsync(Brand brand)
        {
            try
            {
                await brandRepository.AddAsync(brand);
                await unitOfWork.CompleteAsync();

                return new SaveBrandResponse(brand);
            }
            catch (System.Exception exception)
            {
                return new SaveBrandResponse($"An error occurred when saving the category: {exception.Message}");
            }
        }
    }
}