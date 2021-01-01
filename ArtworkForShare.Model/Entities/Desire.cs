using ArtworkForShare.Core.Entity;
using ArtworkForShare.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.Model.Entities
{
    public class Desire : BaseEntity
    {
        public Desire()
        {
            IsActive = true;
            State = ClaimState.NotApproved;
            MadeImgUrl = "notReady.png";
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequestedImgUrl { get; set; }
        public string MadeImgUrl { get; set; }
        public decimal BidPrice { get; set; }
        //Claimer
        public string Fullname { get; set; }
        public string EMail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        //Claimer
        public ClaimState State { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
