using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.WebAPI.Models
{
    public class DesireTableItemDto
    {
        public int DesireId { get; set; }
        public string Title { get; set; }
        public decimal BidPrice { get; set; }
        public string StateDesire { get; set; }
        public string Requestİmg { get; set; }
    }
}
