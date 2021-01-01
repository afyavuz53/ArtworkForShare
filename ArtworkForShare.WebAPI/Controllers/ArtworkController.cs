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
    public class ArtworkController : ControllerBase
    {
        IArtworkBLL artworkBLL;
        public ArtworkController(IArtworkBLL bLL)
        {
            artworkBLL = bLL;
        }
        [HttpPost]
        public IActionResult AddArtwork([FromBody] ArtworkDto input)
        {
            try
            {
                Artwork insert = new Artwork()
                {
                    Name = input.Name,
                    Description = input.Description,
                    ImageUrl = input.Url,
                    UserID = input.UserId
                };
                artworkBLL.Insert(insert);
                return Ok(new { message = "Eser eklendi.", check = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }
        }
        List<ArtworkJustUrlDto> ConvertDtoList(List<Artwork> artworks)
        {
            List<ArtworkJustUrlDto> dtos = new List<ArtworkJustUrlDto>();
            foreach (Artwork item in artworks)
            {
                ArtworkJustUrlDto dto = new ArtworkJustUrlDto()
                {
                    ArtworkID = item.ID,
                    ImageName = item.ImageUrl
                };
                dtos.Add(dto);
            }
            return dtos;
        }
        List<ArtworkForAdmin> ConvertDtoListForAdmin(List<Artwork> artworks)
        {
            List<ArtworkForAdmin> dtos = new List<ArtworkForAdmin>();
            foreach (Artwork item in artworks)
            {
                dtos.Add(new ArtworkForAdmin()
                {
                    ArtworkID = item.ID,
                    ImageName = item.ImageUrl,
                    UserId = item.UserID
                });
            }
            return dtos;
        }
        [HttpGet]
        public IActionResult GetArtworkByID(int uid, int skip)
        {
            return Ok(ConvertDtoList(artworkBLL.GetArtworkByUserId(uid, skip).ToList()));
        }
        [HttpGet]
        public IActionResult GetArtwork(int skip)
        {
            return Ok(ConvertDtoList(artworkBLL.GetAllWithSkip(skip).ToList()));
        }
        [HttpGet]
        public IActionResult GetArtworkByIDForAdmin(int uid, int skip)
        {
            return Ok(ConvertDtoListForAdmin(artworkBLL.GetArtworkByUserId(uid, skip).ToList()));
        }
        [HttpGet]
        public IActionResult GetArtworkForAdmin(int skip)
        {
            List<Artwork> artworks = artworkBLL.GetAllWithSkipForAdmin(skip).ToList();            
            return Ok(ConvertDtoListForAdmin(artworks));
        }
        [HttpGet]
        public IActionResult GetArtworkDetail(int id)
        {
            Artwork artwork = artworkBLL.Get(id);
            ArtworkDetailDto dto = new ArtworkDetailDto()
            {
                Name = artwork.Name,
                Description = artwork.Description,
                Url = artwork.ImageUrl,
                UserId = artwork.UserID,
                UserName = artwork.User.UserName
            };
            return Ok(dto);
        }
        [HttpGet]
        public IActionResult DeleteById(int id)
        {
            artworkBLL.DeleteById(id);
            return Ok();
        }
        [HttpGet]
        public IActionResult SingleArtworkById(int id)
        {
            Artwork artwork = artworkBLL.Get(id);

            return Ok(new ArtworkDto()
            {
                Description = artwork.Description,
                Name = artwork.Name,
                Url = artwork.ImageUrl,
                UserId = artwork.ID
            });
        }
        [HttpPost]
        public IActionResult UpdateArtwork([FromBody] ArtUpdateDto updateDto)
        {
            try
            {
                Artwork update = artworkBLL.Get(updateDto.ArtworkId);
                update.Name = updateDto.Name;
                update.Description = updateDto.Description;
                artworkBLL.Update(update);

                return Ok(new { message = "Eser güncellendi.", check = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }
        }
        [HttpGet]
        public IActionResult ImageBanned(int aid)
        {
            Artwork banned = artworkBLL.Get(aid);
            banned.IsBanned = true;
            banned.ImageUrl = "baned.png";
            banned.Description = "Görseliniz ADMIN tarafından banlanmıştır";
            artworkBLL.Update(banned);
            return Ok();
        }
        [HttpGet]
        public IActionResult Counter()
        {
            int artworkQty = artworkBLL.CounterArtwork();
            int bannedQty = artworkBLL.CounterBannedArtwork();
            return Ok(new { artworkQty, bannedQty });
        }
    }
}
