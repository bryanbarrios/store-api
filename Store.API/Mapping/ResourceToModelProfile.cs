using AutoMapper;
using Store.API.Domain.Models;
using Store.API.Resources;

namespace Store.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap< SaveBrandResource, Brand>();
        }
    }
}