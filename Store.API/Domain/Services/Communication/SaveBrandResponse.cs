using Store.API.Domain.Models;

namespace Store.API.Domain.Services.Communication
{
    public class SaveBrandResponse : BaseResponse
    {
        public Brand Brand { get; private set; }

        private SaveBrandResponse(bool success, string message, Brand brand) : base(success, message)
        {
            Brand = brand;
        }

        // Success Response
        public SaveBrandResponse(Brand brand) : this(true, string.Empty, brand)
        {
            
        }

        // Error Response
        public SaveBrandResponse(string message) : this(false, message, null)
        {
            
        }
    }
}