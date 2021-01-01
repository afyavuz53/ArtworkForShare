using ArtworkForShare.UI.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult ArtistArtworks()
        {
            return View();
        }
        public IActionResult Artists()
        {
            return View();
        }
        public IActionResult Desires()
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
            int[] uId = new int[artworks.Count];
            int[] ids = new int[artworks.Count];
            string[] nUrls = new string[artworks.Count];
            foreach (ArtworkJustImageVM item in artworks)
            {
                ids[i] = item.ArtworkID;
                nUrls[i] = item.ImageName;
                uId[i] = item.UserId;
                i++;
            }
            images.ArtworkIds = ids;
            images.Urls = nUrls;
            images.UserId = uId;
            if (artworks.Count == 9)
            {
                return PartialView("_ImageGroupForAdmin", images);
            }
            else
            {
                return PartialView("_ImageSingleForAdmin", images);
            }
        }
        [HttpPost]
        public IActionResult GetArtistList([FromBody] List<UserSmallVM> vM)
        {
            if (vM.Count==0)
            {
                ViewBag.Message = "Profil bulunamadı.";
                return PartialView("_ArtistNotFoundForAdmin");
            }
            return PartialView("_ArtistProfilsForAdmin", vM);
        }
        [HttpPost]
        public IActionResult LoadDesireTable([FromBody] List<DesireForAdminVM> input)
        {
            if (input.Count==0)
            {
                ViewBag.Message = "İstek yok";
                return PartialView("_NoDesireForAdmin");
            }
            return PartialView("_desireRowForAdmin", input);
        }
    }
}
