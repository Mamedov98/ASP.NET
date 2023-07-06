using FluentApiStudent.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiStudent.Data.DbContexts 
{
    //public class StudentDbContext : DbContext 
    //{
    //    public DbSet<Student> Students { get;set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        ConfigurationBuilder builder = new();
    //        builder.AddJsonFile("appsettings.json");
    //        IConfiguration configuration = builder.Build();
    //        var connectionString = configuration.GetConnectionString("StudentDataBase");
    //        optionsBuilder.UseSqlServer(connectionString);

    //        base.OnConfiguring(optionsBuilder);
    //    }
    //}
}
