using KoreanLicensePlateRecognition.Models.DTOs;

namespace KoreanLicensePlateRecognition.Interfaces
{
    public interface ILicensePlateService
    {
        Task<IEnumerable<LicensePlateDto>> GetAllPlatesAsync();
        Task<LicensePlateDto> GetPlateByIdAsync(int id);
        Task AddPlateAsync(LicensePlateDto licensePlateDto);
        Task UpdatePlateAsync(LicensePlateDto licensePlateDto);
        Task DeletePlateAsync(int id);
    }
}
