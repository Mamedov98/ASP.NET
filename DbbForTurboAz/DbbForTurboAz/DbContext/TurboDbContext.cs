using DbbForTurboAz.Model;
using Microsoft.EntityFrameworkCore;




public class TurboDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<ShowRoom> ShowRooms { get; set; }

    public DbSet<BodyType> BodyTypes { get; set; }

    public DbSet<City> Cities { get; set; }

    public DbSet<Color> Colors { get; set; }

    public DbSet<WheelDriveType> WheelDriveTypes { get; set; }

    public DbSet<FuelType> FuelTypes { get; set; }

    public DbSet<TransmissionType> TransmissionTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TurboAzData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(connectionString);
    }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Make).IsRequired();
                entity.Property(x => x.Model).IsRequired();
                entity.Property(x => x.Year);
                entity.Property(x => x.VIN).IsRequired();
                entity.Property(x => x.Mileage);
                entity.Property(x => x.EngineVolume);
                entity.Property(x => x.HorsePower);
                entity.Property(x => x.PassengerCount);
                entity.Property(x => x.Price).IsRequired();
                entity.Property(x => x.PhoneNumber).IsRequired();

                entity.HasOne(x => x.ShowRoom)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.ShowRoomId);

                entity.HasOne(x => x.BodyType)
                .WithMany()
                .HasForeignKey(x => x.BodyTypeId);

                entity.HasOne(x => x.City)
                .WithMany()
                .HasForeignKey(x => x.CityId);

                entity.HasOne(x => x.WheelDriveType)
                .WithMany()
                .HasForeignKey(x => x.WheelDriveTypeId);


                entity.HasOne(x => x.FuelType) 
             .WithMany()
             .HasForeignKey(x => x.FuelTypeId);

                entity.HasOne(x => x.TransmissionType)
                .WithMany()
                .HasForeignKey(x => x.TransmissionTypeId);


            });

        modelBuilder.Entity<ShowRoom>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();
            entity.Property(x => x.Address).IsRequired();
            entity.Property(x => x.PhoneNumber).IsRequired();

        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();

        });
        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();

        });

        modelBuilder.Entity<WheelDriveType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();

        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();

        });

        modelBuilder.Entity<TransmissionType>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).IsRequired();

        });
        base.OnModelCreating(modelBuilder);
    }
}

