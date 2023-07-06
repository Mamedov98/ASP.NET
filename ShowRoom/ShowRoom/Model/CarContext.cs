using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRooms.Model
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<ShowRoomClass> ShowRoom { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShowRoomData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name).IsRequired().HasMaxLength(64);
                entity.Property(c => c.Model).IsRequired().HasMaxLength(64);
                entity.Property(c => c.Year).IsRequired();
                entity.Property(c => c.Price).HasPrecision(18, 2);
               
                entity.HasOne(c => c.ShowRoom).
                WithMany(s => s.Cars)
                .HasForeignKey(c => c.ShowRoomId)
                .OnDelete(DeleteBehavior.Restrict);


            });
            modelBuilder.Entity<ShowRoomClass>(entity =>
            {


                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name).IsRequired().HasMaxLength(64);
                entity.HasMany(s => s.Cars)
                    .WithOne(c => c.ShowRoom)    
                    .HasForeignKey(c => c.ShowRoomId)
                    .OnDelete(DeleteBehavior.Cascade);


            });


                
            





        }
    }
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public int ShowRoomId { get; set; }
        public virtual ShowRoomClass ShowRoom { get; set; }
      
    }
    public class ShowRoomClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
    
}
