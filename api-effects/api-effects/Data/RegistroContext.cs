using api_effects.Models;
using Microsoft.EntityFrameworkCore;

namespace api_effects.Data
{
    public class RegistroContext : DbContext
    {
        public RegistroContext(DbContextOptions<RegistroContext> opts) : base(opts) 
        { 

        }
        public DbSet<Registro> Registros { get; set; }
    }
}
