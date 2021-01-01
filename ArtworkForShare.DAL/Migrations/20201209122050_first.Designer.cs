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
    [Migration("20201209122050_first")]
    partial class first
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

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("bytea");

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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<decimal>("BidPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("ClaimerID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("MadeImg")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("RequestedImg")
                        .IsRequired()
                        .HasColumnType("bytea");

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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claimer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityAlwaysColumn();

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("ClaimID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("character varying(18)");

                    b.HasKey("ID");

                    b.HasIndex("ClaimID")
                        .IsUnique();

                    b.HasIndex("Fullname")
                        .IsUnique();

                    b.ToTable("Claimer");
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

                    b.Property<byte[]>("ProfileImg")
                        .HasColumnType("bytea");

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
                            ActivationCode = new Guid("5c2bf141-f71f-4496-a5f3-98c7ea116072"),
                            CreatedDate = new DateTime(2020, 12, 9, 15, 20, 49, 902, DateTimeKind.Local).AddTicks(8504),
                            EMail = "artworkforshare@mail.com",
                            FirstName = "ArtworkForShare",
                            IsActive = true,
                            LastName = "ArtworkForShare",
                            PasswordHash = new byte[] { 125, 220, 97, 225, 106, 19, 244, 134, 147, 213, 28, 248, 19, 219, 126, 113, 227, 169, 116, 95, 219, 15, 236, 57, 143, 214, 86, 155, 141, 2, 130, 189, 158, 174, 206, 196, 40, 37, 144, 66, 124, 111, 185, 137, 105, 82, 185, 2, 27, 52, 227, 19, 48, 101, 53, 116, 116, 66, 92, 153, 252, 239, 115, 96 },
                            PasswordSalt = new byte[] { 248, 62, 217, 118, 185, 243, 131, 22, 120, 189, 80, 59, 31, 186, 91, 237, 11, 67, 210, 247, 217, 30, 41, 206, 169, 118, 52, 242, 168, 101, 70, 211, 251, 56, 5, 219, 251, 76, 83, 196, 1, 220, 189, 154, 53, 200, 31, 62, 8, 223, 229, 183, 168, 7, 24, 168, 253, 17, 16, 213, 192, 214, 79, 8, 1, 246, 59, 104, 158, 111, 229, 4, 27, 57, 178, 36, 161, 85, 190, 216, 244, 162, 189, 43, 30, 62, 79, 148, 102, 75, 107, 147, 210, 90, 80, 104, 169, 220, 166, 146, 201, 70, 64, 7, 216, 113, 114, 123, 231, 118, 116, 39, 88, 199, 17, 254, 16, 100, 16, 84, 116, 248, 81, 137, 116, 40, 81, 225 },
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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claim", b =>
                {
                    b.HasOne("ArtworkForShare.Model.Entities.User", "User")
                        .WithMany("Claim")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claimer", b =>
                {
                    b.HasOne("ArtworkForShare.Model.Entities.Claim", "Claim")
                        .WithOne("Claimer")
                        .HasForeignKey("ArtworkForShare.Model.Entities.Claimer", "ClaimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claim", b =>
                {
                    b.Navigation("Claimer");
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