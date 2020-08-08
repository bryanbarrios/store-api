using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.API.Domain.Models;
using Store.API.Domain.Services;
using Store.API.Extensions;
using Store.API.Resources;

namespace Store.API.Controllers
{
    [Route("/api/[controller]")]
    public class BrandsController: Controller
    {
        private readonly IBrandService brandService;
        private readonly IMapper mapper;

        public BrandsController(IBrandService brandService, IMapper mapper)
        {
            this.brandService = brandService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Brand>> GetAllAsync()
        {
            var brands = await brandService.ListAsync();
            return brands;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveBrandResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var brand = mapper.Map<SaveBrandResource, Brand>(resource);
            var result =  await brandService.SaveAsync(brand);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Brand);
        }
    } 
}