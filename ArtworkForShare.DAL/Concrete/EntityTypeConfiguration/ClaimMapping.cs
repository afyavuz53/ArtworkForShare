using ArtworkForShare.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.EntityTypeConfiguration
{
    class ClaimMapping : IEntityTypeConfiguration<Desire>
    {
        public void Configure(EntityTypeBuilder<Desire> builder)
        {
            builder.ToTable("Claim");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID).UseIdentityAlwaysColumn();
            builder.Property(c => c.Title).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(400);
            builder.Property(c => c.RequestedImgUrl).HasMaxLength(100).IsRequired();
            builder.Property(c => c.BidPrice).HasPrecision(10, 2).IsRequired();
            builder.Property(c => c.Fullname).HasMaxLength(100).IsRequired();
            builder.Property(c => c.EMail).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Adress).HasMaxLength(500).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(11).IsRequired();
            builder.Property(d => d.MadeImgUrl).HasMaxLength(100);
        }
    }
}
