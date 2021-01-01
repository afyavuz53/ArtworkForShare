using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Areas.Admin.Models
{
    public class ArtworkJustImageVM
    {
        public int ArtworkID { get; set; }
        public string ImageName { get; set; }
        public int UserId { get; set; }
    }
}
