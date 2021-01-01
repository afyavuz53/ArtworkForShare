using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtworkForShare.BLL.Concrete
{
    class ClaimService : IClaimBLL
    {
        IClaimDAL claimDAL;
        public ClaimService(IClaimDAL dAL)
        {
            claimDAL = dAL;
        }
        void CheckClaim(Desire claim)
        {
            if (string.IsNullOrWhiteSpace(claim.Title))
            {
                throw new Exception("Başlık boş geçilemez.");
            }
            if (claim.BidPrice <= 0)
            {
                throw new Exception("Teklif sıfır yada daha az olamaz.");
            }
            if (string.IsNullOrWhiteSpace(claim.RequestedImgUrl))
            {
                throw new Exception("Lütfen örnek resim koyunuz.");
            }
            if (string.IsNullOrWhiteSpace(claim.Fullname) || string.IsNullOrWhiteSpace(claim.Adress) || string.IsNullOrWhiteSpace(claim.EMail) || string.IsNullOrWhiteSpace(claim.Phone))
            {
                throw new Exception("Lütfen * yerleri boş bırakmayınız.");
            }
            foreach (char item in claim.Fullname)
            {
                if (item!=' ')
                {
                    if (!char.IsLetter(item))
                    {
                        throw new Exception("Ad sadece harflerden oluşmalıdır.");
                    }
                }
            }
            if (claim.Phone.Length != 11)
            {
                throw new Exception("Telefon numarası 11 haneli olmalıdır.");
            }
            foreach (char item in claim.Phone)
            {
                if (!char.IsDigit(item))
                {
                    throw new Exception("Telefon numarası sadece sayı içermelidir.");
                }
            }
            foreach (char item in claim.EMail)
            {
                if (item==' ')
                {
                    throw new Exception("Email adresinde boşluk ' ' bırakmayınız.");
                }
            }
            if (!claim.EMail.Contains('@') && !claim.EMail.Contains(".com"))
            {
                throw new Exception("Lütfen e-mailinizi doğru formatta yazınız.(....@....com)");
            }
        }
        public void Insert(Desire entity)
        {
            CheckClaim(entity);
            claimDAL.Add(entity);
        }

        public void Update(Desire entity)
        {
            CheckClaim(entity);
            claimDAL.Update(entity);
        }

        public void Delete(Desire entity)
        {
            entity.IsActive = false;
            claimDAL.Update(entity);
        }

        public void DeleteById(int id)
        {
            Desire delete = Get(id);
            delete.IsActive = false;
            claimDAL.Update(delete);
        }

        public Desire Get(int id)
        {
            return claimDAL.Get(c => c.ID == id);
        }

        public ICollection<Desire> GetAll()
        {
            return claimDAL.GetAll(c => c.IsActive, c => c.User).OrderByDescending(c => c.CreatedDate).ToList();
        }
        public ICollection<Desire> GetDesireByUserId(int uid)
        {
            return claimDAL.GetAll(c => c.IsActive && c.UserID == uid).OrderByDescending(c => c.CreatedDate).ToList();
        }
        public int CounterDesire()
        {
            return claimDAL.GetAll(c => c.IsActive).Count();
        }
        public int CounterFinishDesire()
        {
            return claimDAL.GetAll(c => c.IsActive && c.State == ClaimState.Finish).Count();
        }
        public int CounterWaitDesire()
        {
            return claimDAL.GetAll(c => c.IsActive && c.State == ClaimState.NotApproved).Count();
        }
        public int CounterNotPaidDesire()
        {
            return claimDAL.GetAll(c => c.IsActive && c.State == ClaimState.NotPaid).Count();
        }
        public int CounterDeniedDesire()
        {
            return claimDAL.GetAll(c => c.IsActive && c.State == ClaimState.Denied).Count();
        }
    }
}
