using ArtworkForShare.Core.Entity;
using ArtworkForShare.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.Model.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            IsActive = false;
            Role = UserRole.Standart;
            ActivationCode = Guid.NewGuid();
            ProfileImgUrl = "emptyprofil.png";
        }
        public string UserName { get; set; }
        public string ProfileImgUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Phone { get; set; }
        public Guid ActivationCode { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Artwork> Artwork { get; set; }
        public ICollection<Desire> Claim { get; set; }
    }
}
