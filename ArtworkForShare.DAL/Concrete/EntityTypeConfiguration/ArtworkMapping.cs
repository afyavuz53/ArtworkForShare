using ArtworkForShare.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.EntityTypeConfiguration
{
    class ArtworkMapping : IEntityTypeConfiguration<Artwork>
    {
        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            builder.ToTable("Artwork");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.ImageUrl).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(400);
        }
    }
}
