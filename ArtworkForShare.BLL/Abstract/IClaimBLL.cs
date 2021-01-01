using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.BLL.Abstract
{
    public interface IClaimBLL : IBaseBLL<Desire>
    {
        ICollection<Desire> GetDesireByUserId(int uid);
        int CounterDesire();
        int CounterFinishDesire();
        int CounterWaitDesire();
        int CounterNotPaidDesire();
        int CounterDeniedDesire();
    }
}
