using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

public partial class CameraSimulatorContext : DbContext
{
    private readonly IConfiguration _configuration;    

    public CameraSimulatorContext(DbContextOptions<CameraSimulatorContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;

    }

    public virtual DbSet<Camera> Cameras { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = _configuration.GetConnectionString("CameraServerContext")!;
        optionsBuilder.UseSqlServer(connectionString);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Camera>(entity =>
        {
            entity.ToTable("Camera");

            entity.Property(e => e.CameraName).HasMaxLength(100);
            entity.Property(e => e.ConnectionCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Password).HasMaxLength(100);

            entity.HasMany(d => d.IdUsers).WithMany(p => p.IdCameras)
                .UsingEntity<Dictionary<string, object>>(
                    "CameraUser",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_CameraUser_User"),
                    l => l.HasOne<Camera>().WithMany()
                        .HasForeignKey("IdCamera")
                        .HasConstraintName("FK_CameraUser_Camera"),
                    j =>
                    {
                        j.HasKey("IdCamera", "IdUser");
                        j.ToTable("CameraUser");
                    });
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");

            entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdVideo)
                .HasConstraintName("FK_User_Video");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.ToTable("Video");

            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
