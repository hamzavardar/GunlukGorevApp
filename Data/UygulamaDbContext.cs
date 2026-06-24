using Microsoft.EntityFrameworkCore;
using GunlukGorevApp.Models;

namespace GunlukGorevApp.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }

        public DbSet<Gorev> Gorevler { get; set; }
    }
}