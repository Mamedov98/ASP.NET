using EntityHW.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHW.data.DbContexts
{
    public class ForeCastdbContext : DbContext
    {
        public DbSet<ForecastHistory> ForecastHistories { get; set; }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new();
            builder.AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("ENTITYTEST");
            optionsBuilder.UseSqlServer();

            base.OnConfiguring(optionsBuilder);
        }
            
    }
}
