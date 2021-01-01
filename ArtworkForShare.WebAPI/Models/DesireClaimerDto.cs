using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.WebAPI.Models
{
    public class DesireClaimerDto
    {
        public string Fullname { get; set; }
        public string EMail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RequestedImgUrl { get; set; }
        public decimal BidPrice { get; set; }
        public int UserID { get; set; }
    }
}
