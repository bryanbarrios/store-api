namespace Store.API.Domain.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string OriginalResolution { get; set; }
        public string HighResolution { get; set; }
        public string MediumResolution { get; set; }
        public string LowResolution { get; set; }
    }
}