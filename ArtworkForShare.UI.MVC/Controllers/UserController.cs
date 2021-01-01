using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.UI.MVC.Helper;
using ArtworkForShare.UI.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ArtworkForShare.UI.MVC.Controllers
{
    [Authorize(Roles = "Standart")]
    public class UserController : Controller
    {
        IUserBLL userBLL;
        [Obsolete]
        IHostingEnvironment _environment;

        [Obsolete]
        public UserController(IUserBLL bLL, IHostingEnvironment hosting)
        {
            _environment = hosting;
            userBLL = bLL;
        }
        public IActionResult Profile()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(userId);
        }
        public IActionResult Update()
        {
            //string userName = HttpContext.User.Identity.Name;
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            User user = userBLL.Get(userId);
            if (user == null)
            {
                ViewBag.Message = "Bir sıkıntı oluştu. Lütfen daha sonra tekrar deneyiniz.";
                return View();
            }
            UserVM userVM = new UserVM()
            {
                UserID = user.ID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                ProfilResmiUrl = user.ProfileImgUrl
            };
            return View(userVM);
        }
        [HttpPost]
        [Obsolete]
        public IActionResult Update(UserVM newData)
        {
            string imageUrl = string.Empty;
            try
            {
                string newUrl = ImageHelper.GetImageUrl(newData.ProfilResmi, _environment);

                //string userName = HttpContext.User.Identity.Name;
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User update = userBLL.Get(userId);
                update.FirstName = newData.FirstName;
                update.LastName = newData.LastName;
                update.Phone = newData.Phone;
                if (newUrl != string.Empty)
                {
                    update.ProfileImgUrl = newUrl;
                }
                else
                {
                    imageUrl = update.ProfileImgUrl;
                }                
                userBLL.UpdateProfile(update);
                return RedirectToAction("Profile");
            }
            catch (Exception ex)
            {
                newData.ProfilResmiUrl = imageUrl;
                ViewBag.Message = ex.Message;
                return View(newData);
            }
        }
        public IActionResult AddArtwork()
        {
            return View();
        }
        [HttpPost]
        [Obsolete]
        public IActionResult AddImage(IFormFile file)
        {
            string newUrl = ImageHelper.GetImageUrl(file, _environment);
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(new { VeriUrl = newUrl, UserId = userId });
        }
        public IActionResult MyGallery()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(userId);
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
                return PartialView("_ImageGroupForUser", images);
            }
            else
            {
                return PartialView("_ImageSingleForUser", images);
            }
        }
        public IActionResult ImageUpdate()
        {
            return View();
        }
        public IActionResult Desires()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(userId);
        }
        public IActionResult ChangePassword(string OldPassword, string NewPassword)
        {
            try
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                userBLL.ChangePassword(userId, OldPassword, NewPassword);
                TempData["Check"] = "success";
                TempData["Message"] = "Şifreniz başarıyla değiştirildi.";
                return RedirectToAction("Update");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                return RedirectToAction("Update", "User");
            }
        }
    }
}
