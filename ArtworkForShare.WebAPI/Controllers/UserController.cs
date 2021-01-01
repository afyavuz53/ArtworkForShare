using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBLL userBLL;
        public UserController(IUserBLL bLL)
        {
            userBLL = bLL;
        }
        List<UserDto> ConvertDtoList(List<User> users)
        {
            List<UserDto> dtos = new List<UserDto>();
            foreach (User item in users)
            {
                dtos.Add(new UserDto { UserID = item.ID, UserName = item.UserName, NameUrl = item.ProfileImgUrl });
            }
            return dtos;
        }
        [HttpGet]
        public IActionResult GetUserAll()
        {
            List<User> users = userBLL.GetAll().ToList();
            return Ok(ConvertDtoList(users));
        }
        [HttpGet]
        public IActionResult GetUserByText(string text)
        {
            List<User> users = userBLL.GetUsersByName(text).ToList();
            return Ok(ConvertDtoList(users));
        }
        [HttpGet]
        public IActionResult GetName(int uid)
        {
            User user = userBLL.Get(uid);
            return Ok(user.UserName);
        }
        [HttpGet]
        public IActionResult ChangePassword(int id, string pwd)
        {
            try
            {
                userBLL.ResetPassword(id, pwd);
                return Ok(new { message = "Şifre değiştirildi.", check = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }
        }
        [HttpGet]
        public IActionResult Counter()
        {
            int userQty=userBLL.CounterUsers();
            return Ok(new { userQty });
        }
    }
}
