﻿// <auto-generated />
using System;
using ArtworkForShare.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtworkForShare.DAL.Migrations
{
    [DbContext(typeof(ArtworkForShareDbContext))]
    [Migration("20201225130959_yirmibesAralik")]
    partial class yirmibesAralik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Artwork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Artwork");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Desire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<decimal>("BidPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("MadeImgUrl")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.Property<string>("RequestedImgUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<Guid>("ActivationCode")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("Phone")
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.Property<string>("ProfileImgUrl")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.HasKey("ID");

                    b.HasIndex("EMail")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActivationCode = new Guid("4db7b308-5cf7-48e2-8318-5a3144e0f5da"),
                            CreatedDate = new DateTime(2020, 12, 25, 16, 9, 58, 490, DateTimeKind.Local).AddTicks(5622),
                            EMail = "artworkforshare@mail.com",
                            FirstName = "ArtworkForShare",
                            IsActive = true,
                            LastName = "ArtworkForShare",
                            PasswordHash = new byte[] { 114, 83, 24, 151, 206, 83, 253, 173, 33, 138, 169, 61, 172, 27, 53, 113, 16, 158, 149, 231, 72, 64, 194, 178, 255, 101, 213, 143, 35, 75, 186, 20, 228, 104, 158, 55, 153, 218, 190, 193, 68, 124, 160, 148, 13, 197, 43, 188, 81, 232, 241, 163, 224, 60, 156, 75, 151, 151, 145, 155, 193, 134, 148, 132 },
                            PasswordSalt = new byte[] { 156, 252, 154, 22, 39, 103, 44, 210, 150, 237, 47, 234, 62, 173, 104, 105, 248, 8, 82, 14, 156, 154, 194, 186, 139, 42, 160, 240, 52, 90, 218, 204, 160, 87, 108, 220, 186, 64, 74, 222, 57, 255, 156, 202, 109, 251, 60, 225, 204, 194, 191, 43, 136, 155, 38, 102, 21, 142, 228, 26, 51, 35, 50, 8, 159, 137, 188, 175, 127, 19, 52, 50, 211, 135, 93, 160, 78, 202, 99, 167, 117, 166, 244, 24, 153, 165, 102, 196, 89, 143, 144, 162, 143, 142, 103, 140, 13, 183, 78, 63, 227, 222, 224, 170, 91, 17, 108, 48, 236, 7, 159, 231, 71, 145, 199, 244, 234, 217, 36, 88, 161, 190, 161, 3, 157, 144, 41, 151 },
                            ProfileImgUrl = "emptyprofil.png",
                            Role = 2,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Artwork", b =>
                {
                    b.HasOne("ArtworkForShare.Model.Entities.User", "User")
                        .WithMany("Artwork")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Desire", b =>
                {
                    b.HasOne("ArtworkForShare.Model.Entities.User", "User")
                        .WithMany("Claim")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.User", b =>
                {
                    b.Navigation("Artwork");

                    b.Navigation("Claim");
                });
#pragma warning restore 612, 618
        }
    }
}
