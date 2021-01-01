using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.Model.Enums;
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
    public class DesireController : ControllerBase
    {
        IClaimBLL claimBLL;
        public DesireController(IClaimBLL claim)
        {
            claimBLL = claim;
        }
        [HttpPost]
        public IActionResult AddDesire([FromBody] DesireClaimerDto Input)
        {
            try
            {
                Desire desire = new Desire()
                {
                    BidPrice = Input.BidPrice,
                    RequestedImgUrl = Input.RequestedImgUrl,
                    UserID = Input.UserID,
                    Title = Input.Title,
                    Description = Input.Description,
                    Fullname = Input.Fullname,
                    Adress = Input.Adress,
                    EMail = Input.EMail,
                    Phone = Input.Phone
                };

                claimBLL.Insert(desire);

                return Ok(new { message = "İstek gönderildi.", check = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }
        }
        [HttpGet]
        public IActionResult GetDesireForUser(int id)
        {
            List<Desire> desires = claimBLL.GetDesireByUserId(id).ToList();
            List<DesireTableItemDto> dtos = new List<DesireTableItemDto>();
            foreach (Desire item in desires)
            {
                DesireTableItemDto dtoItem = new DesireTableItemDto()
                {
                    DesireId = item.ID,
                    Title = item.Title,
                    BidPrice = item.BidPrice,
                    Requestİmg=item.RequestedImgUrl
                };
                switch (item.State)
                {
                    case ClaimState.NotApproved:
                        dtoItem.StateDesire = "Onaylanmadı";
                        break;
                    case ClaimState.NotPaid:
                        dtoItem.StateDesire = "Ödenmedi";
                        break;
                    case ClaimState.Wait:
                        dtoItem.StateDesire = "Bekliyor";
                        break;
                    case ClaimState.Finish:
                        dtoItem.StateDesire = "Bitirildi";
                        break;
                    case ClaimState.Denied:
                        dtoItem.StateDesire = "Reddedildi";
                        break;
                }
                dtos.Add(dtoItem);
            }
            return Ok(dtos);
        }
        [HttpGet]
        public IActionResult GetDetailById(int id)
        {
            Desire desire = claimBLL.Get(id);
            DesireDetailDto detailDto = new DesireDetailDto()
            {
                Title = desire.Title,
                BidPrice = desire.BidPrice,
                Description = desire.Description,
                DesireId = desire.ID,
                RequestImg = desire.RequestedImgUrl,
                StateDesire = desire.State.ToString(),
                MadedImg=desire.MadeImgUrl
            };            
            return Ok(detailDto);
        }
        [HttpGet]
        public IActionResult UpdateDesire(string name, int dId)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Ok(new { message = "Lütfen çizim ekleyiniz.", check = false });
            }
            Desire update = claimBLL.Get(dId);
            update.MadeImgUrl = name;
            update.State = ClaimState.NotPaid;
            claimBLL.Update(update);
            return Ok(new { message = "İstek onaylama başarılı.", check = true });
        }
        [HttpGet]
        public IActionResult RefuseDesire(int dId)
        {
            Desire update = claimBLL.Get(dId);
            update.MadeImgUrl = "denied.jpg";
            update.State = ClaimState.Denied;
            claimBLL.Update(update);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllDesire()
        {
            List<Desire> desires = claimBLL.GetAll().ToList();
            List<DesireForAdminDto> dtos = new List<DesireForAdminDto>();
            foreach (Desire item in desires)
            {
                DesireForAdminDto added =new DesireForAdminDto()
                {
                    DesireId = item.ID,
                    BidPrice = item.BidPrice,
                    UserName = item.User.UserName,                    
                    RequestedImgUrl = item.RequestedImgUrl,
                    MadeImgUrl=item.MadeImgUrl
                };                
                switch (item.State)
                {
                    case ClaimState.NotApproved:
                        added.State = "Onaylanmadı";
                        break;
                    case ClaimState.NotPaid:
                        added.State = "Ödenmedi";
                        break;
                    case ClaimState.Wait:
                        added.State = "Bekliyor";
                        break;
                    case ClaimState.Finish:
                        added.State = "Bitirildi";
                        break;
                    case ClaimState.Denied:
                        added.State = "Reddedildi";
                        break;
                }
                dtos.Add(added);
            }
            return Ok(dtos);
        }
        [HttpGet]
        public IActionResult Counter()
        {
            int desireQty = claimBLL.CounterDesire();
            int finish = claimBLL.CounterFinishDesire();
            int wait = claimBLL.CounterWaitDesire();
            int notPaid = claimBLL.CounterNotPaidDesire();
            int denied = claimBLL.CounterDeniedDesire();
            return Ok(new { desireQty, finish, wait, notPaid, denied });
        }
    }
}
