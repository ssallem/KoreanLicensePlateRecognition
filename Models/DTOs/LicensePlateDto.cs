namespace KoreanLicensePlateRecognition.Models.DTOs
{
    public class LicensePlateDto
    {
        public int Id { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime RecognizedAt { get; set; }
    }
}
