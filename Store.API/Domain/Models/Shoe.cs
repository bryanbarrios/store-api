using System.Collections.Generic;

namespace Store.API.Domain.Models
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public Model Model { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public float price { get; set; }
        public Type Type { get; set; }
        public Image Cover { get; set; }
        public List<Image> Gallery { get; set; }
        public Rating Rating { get; set; }
        public bool IsSpecialEdition { get; set; }
    }
}