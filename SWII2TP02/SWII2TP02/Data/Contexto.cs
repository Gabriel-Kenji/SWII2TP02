using Microsoft.EntityFrameworkCore;
using SWII2TP02.Models;

namespace SWII2TP02.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
           : base(options)
        { }
        public DbSet<SWII2TP02.Models.BL> BL { get; set; }
        public DbSet<SWII2TP02.Models.Container> Container { get; set; }
    }
}