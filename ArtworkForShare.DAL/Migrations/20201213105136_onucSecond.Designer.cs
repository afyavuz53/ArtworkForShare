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
    [Migration("20201213105136_onucSecond")]
    partial class onucSecond
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
                        .HasColumnType("text");

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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Desire", b =>
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

                    b.Property<string>("MadeImgUrl")
                        .HasColumnType("text");

                    b.Property<string>("RequestedImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

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
                        .HasColumnType("text");

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
                            ActivationCode = new Guid("18021378-54ae-49bd-96bc-b919532b88ac"),
                            CreatedDate = new DateTime(2020, 12, 13, 13, 51, 35, 503, DateTimeKind.Local).AddTicks(556),
                            EMail = "artworkforshare@mail.com",
                            FirstName = "ArtworkForShare",
                            IsActive = true,
                            LastName = "ArtworkForShare",
                            PasswordHash = new byte[] { 199, 132, 6, 141, 34, 37, 54, 249, 24, 110, 246, 224, 211, 174, 132, 127, 25, 156, 106, 180, 166, 198, 35, 148, 99, 157, 157, 184, 38, 117, 247, 242, 234, 120, 240, 20, 113, 249, 3, 35, 25, 204, 253, 181, 109, 46, 95, 16, 9, 196, 133, 216, 64, 4, 87, 211, 57, 107, 99, 252, 232, 196, 124, 92 },
                            PasswordSalt = new byte[] { 209, 151, 85, 167, 146, 140, 15, 97, 46, 216, 110, 44, 80, 138, 50, 50, 54, 133, 70, 104, 186, 228, 167, 97, 50, 121, 208, 184, 229, 79, 179, 22, 66, 74, 177, 175, 116, 255, 126, 144, 178, 239, 160, 56, 206, 123, 83, 139, 116, 33, 53, 49, 133, 142, 191, 21, 99, 51, 147, 113, 123, 12, 108, 137, 131, 77, 236, 78, 186, 128, 139, 41, 101, 38, 43, 50, 225, 128, 203, 215, 255, 205, 68, 139, 107, 4, 224, 21, 186, 180, 191, 243, 84, 23, 228, 23, 144, 204, 143, 92, 210, 23, 65, 160, 37, 243, 55, 172, 59, 213, 119, 3, 166, 21, 1, 250, 183, 95, 68, 207, 18, 148, 222, 205, 199, 77, 250, 0 },
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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Claimer", b =>
                {
                    b.HasOne("ArtworkForShare.Model.Entities.Desire", "Claim")
                        .WithOne("Claimer")
                        .HasForeignKey("ArtworkForShare.Model.Entities.Claimer", "ClaimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
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

            modelBuilder.Entity("ArtworkForShare.Model.Entities.Desire", b =>
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
