using KoreanLicensePlateRecognition.Data;
using KoreanLicensePlateRecognition.Interfaces;
using KoreanLicensePlateRecognition.Repositories;
using KoreanLicensePlateRecognition.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext 등록
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 서비스 및 리포지토리 등록
builder.Services.AddScoped<ILicensePlateService, LicensePlateService>();
builder.Services.AddScoped<ILicensePlateRepository, LicensePlateRepository>();

// 기타 서비스 설정
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware 설정
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
