using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Areas.Admin.Models
{
    public class ImageVM
    {
        public int[] ArtworkIds { get; set; }
        public string[] Urls { get; set; }
        public int[] UserId { get; set; }
    }
}
