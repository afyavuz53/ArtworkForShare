using ArtworkForShare.DAL.Helper;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.EntityTypeConfiguration
{
    class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(a => a.ID);
            builder.Property(u => u.ID).UseIdentityAlwaysColumn();
            builder.Property(u => u.UserName).HasMaxLength(30).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Phone).HasMaxLength(11);
            builder.Property(u => u.EMail).HasMaxLength(50).IsRequired();
            builder.Property(u => u.ProfileImgUrl).HasMaxLength(200);
            builder.HasIndex(u => u.EMail).IsUnique();
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.Ignore(u => u.Password);

            #region AdminEkleme
            byte[] _hash;
            byte[] _salt;
            PasswordHelperDAL.CreatePasswordHash("123", out _hash, out _salt);

            builder.HasData(new User()
            {
                ID = 1,
                UserName = "Admin",
                FirstName = "ArtworkForShare",
                LastName = "ArtworkForShare",
                EMail = "artworkforshare@mail.com",
                PasswordHash = _hash,
                PasswordSalt = _salt,
                IsActive = true,
                Role=UserRole.Admin
            }); 
            #endregion
        }
    }
}
