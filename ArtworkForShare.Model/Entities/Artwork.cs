using ArtworkForShare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.Model.Entities
{
    public class Artwork : BaseEntity
    {
        public Artwork()
        {
            IsActive = true;
            IsBanned = false;
        }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public bool IsBanned { get; set; }
    }
}
