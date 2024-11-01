using KoreanLicensePlateRecognition.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KoreanLicensePlateRecognition.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // LicensePlate 엔티티를 데이터베이스 테이블로 매핑
        public DbSet<LicensePlate> LicensePlates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // LicensePlate 엔티티의 기본 설정 (예: 테이블 이름, 키 설정)
            modelBuilder.Entity<LicensePlate>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PlateNumber)
                      .IsRequired()
                      .HasMaxLength(15);
                entity.Property(e => e.RecognizedAt)
                      .IsRequired();
            });
        }
    }
}
