using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Models
{
    public class DesireDetailVM
    {
        public int DesireId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal BidPrice { get; set; }
        public string RequestImg { get; set; }
        public string MadedImg { get; set; }
        public string StateDesire { get; set; }
    }
}
