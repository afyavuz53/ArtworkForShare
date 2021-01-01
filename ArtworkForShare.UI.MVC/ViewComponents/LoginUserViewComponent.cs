using ArtworkForShare.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.ViewComponents
{
    public class LoginUserViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            LoginUser user = new LoginUser() { UserName = HttpContext.User.Identity.Name };
            return View(user);
        }
    }
}
