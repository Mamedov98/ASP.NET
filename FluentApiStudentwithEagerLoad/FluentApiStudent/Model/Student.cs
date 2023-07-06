using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FluentApiStudent.Model
{
    /* public class Student
      {
          [Key]

          public int Id { get; set; }

          [Required]
          public string Name { get; set; }


          [Required]
          public string Surname { get; set; }

          [Required]
          public DateTime DateOfBirth { get; set; }

          public string Group { get; set; }

      }*/

    public class StudentContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentEagerDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            using (var context = new StudentContext())
            {
                var students = context.Students.Include(s => s.Group).ToList();
            }
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Name)
                    .IsRequired();
                entity.Property(entity => entity.Surname)
                    .IsRequired();
                entity.Property(entity => entity.DateOfBirth)
                    .IsRequired();
                entity.Property(entity => entity.GroupId);

               
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Name).IsRequired().HasMaxLength(64);
                

               
                
            });
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }



        public virtual ICollection<Group> Groups { get; set; }

    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

