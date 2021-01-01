using ArtworkForShare.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Artists()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoadImages([FromBody] List<ArtworkJustImageVM> artworks)
        {
            if (artworks.Count == 0)
            {
                return PartialView("_ImageWarning");
            }
            ImageVM images = new ImageVM();
            int i = 0;
            int[] ids = new int[artworks.Count];
            string[] nUrls = new string[artworks.Count];
            foreach (ArtworkJustImageVM item in artworks)
            {
                ids[i] = item.ArtworkID;
                nUrls[i] = item.ImageName;
                i++;
            }
            images.ArtworkIds = ids;
            images.Urls = nUrls;
            if (artworks.Count == 9)
            {
                return PartialView("_ImageGroup", images);
            }
            else
            {
                return PartialView("_ImageSingle", images);
            }
        }        
        public IActionResult ArtistArtworks()
        {            
            return View();
        }
        public IActionResult ImageDetail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetDetail([FromBody]ArtworkDetailVM detailVM)
        {
            if (detailVM==null)
            {
                ViewBag.Message = "Eser Yok";
                return RedirectToAction("Gallery");
            }
            return PartialView("_DetailArt",detailVM);
        }
        [HttpPost]
        public IActionResult GetArtistList([FromBody]List<UserSmallVM> vM)
        {
            if (vM.Count==0)
            {
                ViewBag.Message = "Profil bulunamadı.";
                return PartialView("_ArtistNotFound");
            }
            return PartialView("_ArtistProfils", vM);
        }
    }
}
