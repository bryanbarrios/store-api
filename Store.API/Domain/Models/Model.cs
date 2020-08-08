namespace Store.API.Domain.Models
{
    public class Model
    {  
        public int ModelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public Material Material { get; set; }
        public Style Style { get; set; }
    }
}