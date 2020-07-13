namespace Store.API.Domain.Models
{
    class Rating
    {
        private int RatingId { get; set; }
        private Shoe Shoe { get; set; }
        private User User { get; set; }
        private float RatingValue { get; set; }
    }
}