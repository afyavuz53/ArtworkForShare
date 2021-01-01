using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.WebAPI.Models
{
    public class ArtworkDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
    }
}
