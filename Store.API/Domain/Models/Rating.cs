namespace Store.API.Domain.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public Shoe Shoe { get; set; }
        public User User { get; set; }
        public float RatingValue { get; set; }
    }
}