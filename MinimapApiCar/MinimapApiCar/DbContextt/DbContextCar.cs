using Microsoft.EntityFrameworkCore;

namespace MinimapApiCar.DbContextt
{
    public class DbContextCar : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbContextCar(DbContextOptions<DbContextCar> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarDataBaseApi;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Name)
                .IsRequired();
                entity.Property(entity => entity.Model)
                .IsRequired();
                entity.Property(entity => entity.Price)
                .IsRequired();
                entity.Property(entity => entity.Year);
            });
        }
    }
}
