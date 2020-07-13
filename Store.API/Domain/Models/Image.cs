namespace Store.API.Domain.Models
{
    class Image
    {
        private int ImageId { get; set; }
        private string OriginalResolution { get; set; }
        private string HighResolution { get; set; }
        private string MediumResolution { get; set; }
        private string LowResolution { get; set; }
    }
}