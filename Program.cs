using Microsoft.EntityFrameworkCore;
using GunlukGorevApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// SQLite Ayarı
builder.Services.AddDbContext<UygulamaDbContext>(options =>
    options.UseSqlite("Data Source=Gorevler.db"));

// Controller Servisleri
builder.Services.AddControllers();

// Swagger Test Ekranı Servisleri
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger Arayüzünü Aktif Et
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Bu satır swagger sayfasını açar
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

// API Rotalarını (GorevlerController gibi) Eşleştir
app.MapControllers();

app.Run();