using ArtworkForShare.Core.DataAccess.EntityFramework;
using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.DAL.Concrete.Repositories
{
    class ClaimRepository:EFRepositoryBase<Desire,ArtworkForShareDbContext>,IClaimDAL
    {
    }
}
