using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Areas.Admin.Models
{
    public class DesireForAdminVM
    {
        public int DesireId { get; set; }
        public string RequestedImgUrl { get; set; }
        public string MadeImgUrl { get; set; }
        public decimal BidPrice { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
    }
}
