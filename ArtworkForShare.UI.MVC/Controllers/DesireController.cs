using ArtworkForShare.Model.Enums;
using ArtworkForShare.UI.MVC.Helper;
using ArtworkForShare.UI.MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Controllers
{
    public class DesireController : Controller
    {
        [Obsolete]
        IHostingEnvironment _environment;
        [Obsolete]
        public DesireController(IHostingEnvironment hosting)
        {
            _environment = hosting;
        }
        public IActionResult SendDesire()
        {
            return View();
        }

        [Obsolete]
        public IActionResult AddImage(IFormFile file)
        {
            string newName = ImageHelper.GetRequestImg(file, _environment);
            return Ok(new { imgUrl = newName });
        }
        [HttpPost]
        public IActionResult LoadDesireTable([FromBody] List<DesireTableItemVM> input)
        {
            if (input.Count==0)
            {
                ViewBag.Message = "İstek yok";
                return PartialView("_NoDesire");
            }
            return PartialView("_desireRow", input);
        }
        public IActionResult Detail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetDesireDetail([FromBody]DesireDetailVM detailVM)
        {
            if (detailVM==null)
            {
                ViewBag.Message = "İstek yok.";
                return RedirectToAction("Desires", "User");
            }
            if (detailVM.StateDesire==ClaimState.NotApproved.ToString())
            {
                return PartialView("_DesireDetail", detailVM);
            }
            return PartialView("_FinishDesireDetail", detailVM);
        }
    }
}
