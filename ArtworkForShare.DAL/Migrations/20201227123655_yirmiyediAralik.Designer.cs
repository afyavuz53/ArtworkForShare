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
    [Migration("20201227123655_yirmiyediAralik")]
    partial class yirmiyediAralik
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

                    b.Property<bool>("IsBanned")
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
                            ActivationCode = new Guid("ad9cf52b-c1a1-4f67-a10a-54248e41e5f1"),
                            CreatedDate = new DateTime(2020, 12, 27, 15, 36, 54, 783, DateTimeKind.Local).AddTicks(3134),
                            EMail = "artworkforshare@mail.com",
                            FirstName = "ArtworkForShare",
                            IsActive = true,
                            LastName = "ArtworkForShare",
                            PasswordHash = new byte[] { 115, 175, 30, 147, 132, 205, 189, 71, 33, 123, 77, 243, 196, 72, 122, 80, 184, 93, 164, 51, 162, 151, 144, 18, 178, 47, 251, 99, 13, 181, 99, 110, 111, 163, 139, 1, 243, 193, 227, 206, 160, 191, 201, 192, 136, 22, 21, 172, 189, 56, 190, 31, 229, 118, 8, 240, 163, 75, 35, 71, 75, 31, 60, 108 },
                            PasswordSalt = new byte[] { 100, 17, 33, 102, 35, 168, 29, 246, 217, 15, 51, 69, 73, 252, 5, 67, 116, 30, 76, 123, 124, 229, 70, 34, 6, 151, 211, 94, 222, 169, 133, 188, 99, 15, 236, 46, 64, 59, 18, 170, 70, 126, 147, 45, 96, 233, 198, 249, 159, 174, 44, 229, 224, 154, 64, 20, 25, 146, 189, 247, 121, 174, 181, 59, 174, 28, 184, 206, 226, 96, 72, 18, 37, 231, 245, 186, 182, 141, 155, 108, 165, 85, 230, 181, 167, 171, 48, 86, 93, 54, 162, 245, 105, 184, 165, 246, 100, 121, 223, 26, 25, 5, 13, 138, 99, 2, 140, 123, 118, 96, 173, 139, 3, 45, 221, 197, 187, 144, 19, 167, 135, 124, 28, 189, 19, 46, 36, 232 },
                            ProfileImgUrl = "emptyprofil.png",
                            Role = 1,
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
