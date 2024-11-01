﻿// <auto-generated />
using System;
using CameraServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CameraServer.Migrations
{
    [DbContext(typeof(CameraSimulatorContext))]
    partial class CameraSimulatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CameraServer.Models.Camera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CameraName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ConnectionCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Camera");
                });

            modelBuilder.Entity("CameraServer.Models.CameraUser", b =>
                {
                    b.Property<int>("IdCamera")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasIndex("IdCamera");

                    b.HasIndex("IdUser");

                    b.ToTable("CameraUser");
                });

            modelBuilder.Entity("CameraServer.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CameraServer.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cookie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<int?>("IdVideo")
                        .HasColumnType("int");

                    b.Property<bool?>("IsBan")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.HasIndex("IdVideo");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CameraServer.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nchar(500)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("CameraServer.Models.CameraUser", b =>
                {
                    b.HasOne("CameraServer.Models.Camera", "IdCameraNavigation")
                        .WithMany()
                        .HasForeignKey("IdCamera")
                        .IsRequired()
                        .HasConstraintName("FK_CameraUser_Camera");

                    b.HasOne("CameraServer.Models.User", "IdUserNavigation")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .IsRequired()
                        .HasConstraintName("FK_CameraUser_User");

                    b.Navigation("IdCameraNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("CameraServer.Models.User", b =>
                {
                    b.HasOne("CameraServer.Models.Role", "IdRoleNavigation")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.HasOne("CameraServer.Models.Video", "IdVideoNavigation")
                        .WithMany("Users")
                        .HasForeignKey("IdVideo")
                        .HasConstraintName("FK_User_Video");

                    b.Navigation("IdRoleNavigation");

                    b.Navigation("IdVideoNavigation");
                });

            modelBuilder.Entity("CameraServer.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("CameraServer.Models.Video", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
