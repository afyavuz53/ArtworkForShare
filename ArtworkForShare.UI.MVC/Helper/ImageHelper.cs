using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Helper
{
    public static class ImageHelper
    {
        [Obsolete]
        public static string GetImageUrl(IFormFile file, IHostingEnvironment environment)
        {
            string resimler = Path.Combine(environment.WebRootPath, "Content/Images");
            string newUrl = string.Empty;
            if (file != null)
            {
                string dosya = file.FileName;
                string[] dosyaArray = dosya.Split('.');
                newUrl = Guid.NewGuid().ToString() + "." + dosyaArray[dosyaArray.Length - 1];

                using (var fileStream = new FileStream(Path.Combine(resimler, newUrl), FileMode.Create))                
                {
                    file.CopyTo(fileStream);
                }
            }
            return newUrl;
        }
        [Obsolete]
        public static string GetRequestImg(IFormFile file, IHostingEnvironment environment)
        {
            string resimler = Path.Combine(environment.WebRootPath, "Content/ClaimImages");
            string newUrl = string.Empty;
            if (file != null)
            {
                string dosya = file.FileName;
                string[] dosyaArray = dosya.Split('.');
                newUrl = Guid.NewGuid().ToString() + "." + dosyaArray[dosyaArray.Length - 1];

                using (var fileStream = new FileStream(Path.Combine(resimler, newUrl), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return newUrl;
        }
    }
}
