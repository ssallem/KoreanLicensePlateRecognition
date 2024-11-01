using KoreanLicensePlateRecognition.Data;
using KoreanLicensePlateRecognition.Interfaces;
using KoreanLicensePlateRecognition.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KoreanLicensePlateRecognition.Repositories
{
    public class LicensePlateRepository : ILicensePlateRepository
    {
        private readonly AppDbContext _context;

        public LicensePlateRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LicensePlate>> GetAllAsync()
        {
            return await _context.LicensePlates.ToListAsync();
        }

        public async Task<LicensePlate> GetByIdAsync(int id)
        {
            return await _context.LicensePlates.FindAsync(id);
        }

        public async Task AddAsync(LicensePlate licensePlate)
        {
            await _context.LicensePlates.AddAsync(licensePlate);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LicensePlate licensePlate)
        {
            _context.LicensePlates.Update(licensePlate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var licensePlate = await GetByIdAsync(id);
            if (licensePlate != null)
            {
                _context.LicensePlates.Remove(licensePlate);
                await _context.SaveChangesAsync();
            }
        }
    }
}
