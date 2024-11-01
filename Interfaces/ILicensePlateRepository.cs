using KoreanLicensePlateRecognition.Models.Entities;

namespace KoreanLicensePlateRecognition.Interfaces
{
    public interface ILicensePlateRepository
    {
        Task<IEnumerable<LicensePlate>> GetAllAsync();
        Task<LicensePlate> GetByIdAsync(int id);
        Task AddAsync(LicensePlate licensePlate);
        Task UpdateAsync(LicensePlate licensePlate);
        Task DeleteAsync(int id);
    }
}