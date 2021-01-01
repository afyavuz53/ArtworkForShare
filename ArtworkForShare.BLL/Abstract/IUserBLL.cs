using ArtworkForShare.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtworkForShare.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        User GetUserByActCode(Guid guid);
        User GetUserForLogin(string userName, string password);
        User GetUserByUsername(string name);
        void UpdateProfile(User user);
        void ChangePassword(int id, string OldPassword, string NewPassword);
        int CheckUserForPassword(string userName, string eMail, string firstName, string lastName);
        void ResetPassword(int uid, string password);
        ICollection<User> GetUsersByName(string text);
        int CounterUsers();
    }
}
