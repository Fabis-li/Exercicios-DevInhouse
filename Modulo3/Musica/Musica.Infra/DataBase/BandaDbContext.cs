using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Musica.Domain.Models;
using Musica.Infra.DataBase.Mappings;

namespace Musica.Infra.DataBase
{
    public class BandaDbContext : DbContext
    {        
        public DbSet<BandaModel> Bandas{ get; set;}

        private readonly IConfiguration _configuration;
        public BandaDbContext (IConfiguration configuration)
        {
            _configuration = configuration;
        }       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {     
            options.UseSqlServer(_configuration.GetConnectionString("ConexaoBanco"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                       
            modelBuilder.ApplyConfiguration(new BandaMap());
        }
    }
}

    
