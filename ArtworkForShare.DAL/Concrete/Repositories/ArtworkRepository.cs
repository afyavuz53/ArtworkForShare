using ArtworkForShare.Core.DataAccess.EntityFramework;
using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.Repositories
{
    class ArtworkRepository:EFRepositoryBase<Artwork,ArtworkForShareDbContext>,IArtworkDAL
    {
    }
}
