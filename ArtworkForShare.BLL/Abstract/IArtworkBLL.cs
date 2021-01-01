using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.BLL.Abstract
{
    public interface IArtworkBLL : IBaseBLL<Artwork>
    {
        ICollection<Artwork> GetArtworkByUserId(int uid, int skip);
        ICollection<Artwork> GetAllWithSkip(int skip);
        ICollection<Artwork> GetAllWithSkipForAdmin(int skip);
        int CounterBannedArtwork();
        int CounterArtwork();
    }
}
