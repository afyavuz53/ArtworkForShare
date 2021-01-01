using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.WebAPI.Models
{
    public class ArtUpdateDto
    {
        public int ArtworkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
