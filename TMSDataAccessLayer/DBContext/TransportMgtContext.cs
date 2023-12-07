using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TMSDataAccessLayer.DBContext;

public partial class TransportMgtContext : DbContext
{
    public TransportMgtContext()
    {
    }

    public TransportMgtContext(DbContextOptions<TransportMgtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    public virtual DbSet<Vender> Venders { get; set; }

    public virtual DbSet<VerificationTrip> VerificationTrips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SOURABH_PC\\SQLEXPRESS;Initial Catalog=transportMgt;Integrated Security=True ; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.DriverId).HasName("PK__Driver__F1B1CD04315FA570");

            entity.ToTable("Driver");

            entity.Property(e => e.DriverEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DriverName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DriverPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.ProfilePhoto)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.VenderNavigation).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.Vender)
                .HasConstraintName("FK__Driver__Vender__412EB0B6");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A2AD24BF6");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK__Route__80979B4D2CF8C713");

            entity.ToTable("Route");

            entity.Property(e => e.DestinationAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.RouteName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.HasKey(e => e.TripId).HasName("PK__Trip__51DC713E106AB699");

            entity.ToTable("Trip");

            entity.Property(e => e.IsCompleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.TripDate).HasColumnType("date");

            entity.HasOne(d => d.Driver).WithMany(p => p.Trips)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("FK__Trip__DriverId__48CFD27E");

            entity.HasOne(d => d.Route).WithMany(p => p.Trips)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__Trip__RouteId__49C3F6B7");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Trips)
                .HasForeignKey(d => d.VehicleId)
                .HasConstraintName("FK__Trip__VehicleId__47DBAE45");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C1D8427A1");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleId__5441852A");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicle__476B549285FD7FD8");

            entity.ToTable("Vehicle");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.VehicleName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VehicleNumber)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.VehicleTypeNavigation).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleType)
                .HasConstraintName("FK__Vehicle__Vehicle__3C69FB99");

            entity.HasOne(d => d.VenderNavigation).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.Vender)
                .HasConstraintName("FK__Vehicle__Vender__3D5E1FD2");
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK__VehicleT__516F03B55A9BD8B9");

            entity.ToTable("VehicleType");

            entity.Property(e => e.TypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vender>(entity =>
        {
            entity.HasKey(e => e.VenderId).HasName("PK__Vender__AAFFC683C84F2219");

            entity.ToTable("Vender");

            entity.Property(e => e.Decription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImgPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.VenderName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VerificationTrip>(entity =>
        {
            entity.HasKey(e => e.VerificationTripId).HasName("PK__Verifica__1A6695E0C91F45FA");

            entity.ToTable("VerificationTrip");

            entity.Property(e => e.DriverName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VehicleNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Trip).WithMany(p => p.VerificationTrips)
                .HasForeignKey(d => d.TripId)
                .HasConstraintName("FK__Verificat__TripI__4F7CD00D");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.VerificationTrips)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__Verificat__Verif__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
