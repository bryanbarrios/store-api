using System.Collections.Generic;

namespace Store.API.Domain.Models
{
    class Shoe
    {
        private int ShoeId { get; set; }
        private Model Model { get; set; }
        private Color Color { get; set; }
        private Size Size { get; set; }
        private float price { get; set; }
        private Type Type { get; set; }
        private Image Cover { get; set; }
        private List<Image> Gallery { get; set; }
        private Rating Rating { get; set; }
        private bool IsSpecialEdition { get; set; }
    }
}