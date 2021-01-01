using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.Model.Enums;
using ArtworkForShare.UI.MVC.Helper;
using ArtworkForShare.UI.MVC.Models;
using ArtworkForShare.UI.MVC.Models.MySession;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserBLL userBLL;
        public AccountController(IUserBLL bLL)
        {
            userBLL = bLL;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(registerVM register)
        {
            try
            {
                MyData myData = HttpContext.Session.Get<MyData>("data");
                myData.UpdateData(register);
                User newUser = new User()
                {
                    ID = 0,
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    UserName = register.UserName,
                    Password = register.Password,
                    Phone = register.Phone,
                    EMail = register.Email
                };
                userBLL.Insert(newUser);
                bool result = MailHelper.SendActivationCode(newUser.UserName, newUser.EMail, newUser.ActivationCode);
                if (result)
                {
                    myData.DeleteData();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.Message = "Activasyon mailli gönderilemedi lütfen bilgilerinizi kontrol ediniz.";
                    userBLL.Delete(newUser);
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                return View();
            }
        }
        [HttpGet]
        public IActionResult LoadData()
        {
            MyData myData = HttpContext.Session.Get<MyData>("data");
            registerVM register = myData.GetData;
            return Ok(register);
        }
        public IActionResult ActivationUser(Guid id)
        {
            User newUser = userBLL.GetUserByActCode(id);
            if (newUser != null)
            {
                newUser.IsActive = true;
                userBLL.Update(newUser);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Aktif edilecek kullanıcı bulunamadı.";
                return View();
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(loginVM login)
        {
            try
            {
                User loginUser = userBLL.GetUserForLogin(login.UserName, login.Password);

                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,loginUser.UserName),
                    new Claim(ClaimTypes.Role,loginUser.Role.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,loginUser.ID.ToString())
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                if (loginUser.Role == UserRole.Admin)
                {
                    //admin giriş
                    return RedirectToAction("Index", "Management", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Profile", "User");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Gallery", "Home");
        }
        public IActionResult RecoverPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RecoverPassword(RecoverPasswordVM passwordVM)
        {
            try
            {
                int id = userBLL.CheckUserForPassword(passwordVM.Username, passwordVM.Email, passwordVM.FirstName, passwordVM.LastName);
                bool check = MailHelper.RecoverPasswordMail(passwordVM.Username, passwordVM.Email, id);
                if (check)
                {
                    ViewBag.Check = "success";
                    ViewBag.Message = "E-mail adresinize link gönderildi.";
                }
                else
                {
                    throw new Exception("Şuan da şifre yenileme linki gönderilemiyor. Daha sonra tekrar deneyiniz.");
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
