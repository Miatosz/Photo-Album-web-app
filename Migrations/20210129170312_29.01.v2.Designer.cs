﻿// <auto-generated />
using System;
using ImageAlbumAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImageAlbumAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210129170312_29.01.v2")]
    partial class _2901v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ImageAlbumAPI.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("DateOfAdd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.Album", b =>
                {
                    b.HasOne("ImageAlbumAPI.Models.User", "User")
                        .WithMany("Albums")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.Photo", b =>
                {
                    b.HasOne("ImageAlbumAPI.Models.Album", "Album")
                        .WithMany("Photos")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ImageAlbumAPI.Models.User", null)
                        .WithMany("Photos")
                        .HasForeignKey("UserId");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.Album", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("ImageAlbumAPI.Models.User", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}