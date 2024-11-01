namespace KoreanLicensePlateRecognition.Models.Entities
{
    public class LicensePlate
    {
        public int Id { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime RecognizedAt { get; set; }
        public required string? ImagePath { get; set; }  // 이미지 경로 저장
    }
}
