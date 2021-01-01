using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtworkForShare.BLL.Concrete
{
    class ArtworkService : IArtworkBLL
    {
        IArtworkDAL artworkDAL;
        public ArtworkService(IArtworkDAL dAL)
        {
            artworkDAL = dAL;
        }
        void CheckArtwork(Artwork artwork)
        {
            if (string.IsNullOrWhiteSpace(artwork.Name)|| string.IsNullOrWhiteSpace(artwork.ImageUrl))
            {
                throw new Exception("Eseriniz ve adı boş geçilemez.");
            }
        }
        public void Insert(Artwork entity)
        {
            CheckArtwork(entity);
            artworkDAL.Add(entity);
        }

        public void Update(Artwork entity)
        {
            CheckArtwork(entity);
            artworkDAL.Update(entity);
        }

        public void Delete(Artwork entity)
        {
            entity.IsActive = false;
            artworkDAL.Update(entity);
        }

        public void DeleteById(int id)
        {
            Artwork artwork = Get(id);
            artwork.IsActive = false;
            artworkDAL.Update(artwork);
        }

        public Artwork Get(int id)
        {
            return artworkDAL.Get(a => a.ID == id,a=>a.User);
        }

        public ICollection<Artwork> GetAll()
        {
            return artworkDAL.GetAll(a => a.IsActive);
        }
        public ICollection<Artwork> GetArtworkByUserId(int uid,int skip)
        {
            return artworkDAL.GetAll(a => a.IsActive && a.UserID == uid).OrderByDescending(a=>a.CreatedDate).Skip(skip).Take(9).ToList();
        }
        public ICollection<Artwork> GetAllWithSkip(int skip)
        {
            return artworkDAL.GetAll(a => a.IsActive&&!a.IsBanned).OrderByDescending(a => a.CreatedDate).Skip(skip).Take(9).ToList();
        }
        public ICollection<Artwork> GetAllWithSkipForAdmin(int skip)
        {
            return artworkDAL.GetAll(a => a.IsActive).OrderByDescending(a => a.CreatedDate).Skip(skip).Take(9).ToList();
        }
        public int CounterArtwork()
        {
            return artworkDAL.GetAll(a => a.IsActive).Count();
        }
        public int CounterBannedArtwork()
        {
            return artworkDAL.GetAll(a => a.IsActive&&a.IsBanned).Count();
        }
    }
}
