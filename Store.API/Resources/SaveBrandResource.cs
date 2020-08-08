using System.ComponentModel.DataAnnotations;

namespace Store.API.Resources
{
    public class SaveBrandResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}