using KoreanLicensePlateRecognition.Interfaces;
using KoreanLicensePlateRecognition.Models.DTOs;
using KoreanLicensePlateRecognition.Models.Entities;

namespace KoreanLicensePlateRecognition.Services
{
    public class LicensePlateService : ILicensePlateService
    {
        private readonly ILicensePlateRepository _repository;

        public LicensePlateService(ILicensePlateRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<LicensePlateDto>> GetAllPlatesAsync()
        {
            var plates = await _repository.GetAllAsync();
            return plates.Select(p => new LicensePlateDto
            {
                Id = p.Id,
                PlateNumber = p.PlateNumber,
                RecognizedAt = p.RecognizedAt
            });
        }

        public async Task<LicensePlateDto> GetPlateByIdAsync(int id)
        {
            var plate = await _repository.GetByIdAsync(id);
            return plate == null ? null : new LicensePlateDto
            {
                Id = plate.Id,
                PlateNumber = plate.PlateNumber,
                RecognizedAt = plate.RecognizedAt
            };
        }

        public async Task AddPlateAsync(LicensePlateDto licensePlateDto)
        {
            var plate = new LicensePlate
            {
                PlateNumber = licensePlateDto.PlateNumber,
                RecognizedAt = licensePlateDto.RecognizedAt,
                ImagePath = null,
            };
            await _repository.AddAsync(plate);
        }

        public async Task UpdatePlateAsync(LicensePlateDto licensePlateDto)
        {
            var plate = await _repository.GetByIdAsync(licensePlateDto.Id);
            if (plate != null)
            {
                plate.PlateNumber = licensePlateDto.PlateNumber;
                plate.RecognizedAt = licensePlateDto.RecognizedAt;
                await _repository.UpdateAsync(plate);
            }
        }

        public async Task DeletePlateAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
