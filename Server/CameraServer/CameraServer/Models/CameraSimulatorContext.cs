using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Models;

public partial class CameraSimulatorContext : DbContext
{
    private IConfiguration _configuration;
    public CameraSimulatorContext()
    { 
    }

    public CameraSimulatorContext(DbContextOptions<CameraSimulatorContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Camera> Cameras { get; set; } 

    public virtual DbSet<CameraUser> CameraUsers { get; set; }

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
            entity.Property(e => e.ConnectionCode).IsFixedLength();
        });

        modelBuilder.Entity<CameraUser>(entity =>
        {
            entity.HasOne(d => d.IdCameraNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CameraUser_Camera");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CameraUser_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email).IsFixedLength();

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");

            entity.HasOne(d => d.IdVideoNavigation).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Video");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.Property(e => e.Url).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
