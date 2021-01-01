using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Models
{
    public class UserVM
    {
        public int UserID { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Phone { get; set; }
        public string ProfilResmiUrl { get; set; }
        public IFormFile ProfilResmi { get; set; }
    }
}
