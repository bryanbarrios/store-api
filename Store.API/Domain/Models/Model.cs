namespace Store.API.Domain.Models
{
    class Model
    {  
        private int ModelId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private Category Category { get; set; }
        private Brand Brand { get; set; }
        private Material Material { get; set; }
        private Style Style { get; set; }
    }
}