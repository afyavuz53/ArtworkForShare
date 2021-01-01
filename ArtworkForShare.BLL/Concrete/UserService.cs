using ArtworkForShare.BLL.Abstract;
using ArtworkForShare.BLL.Helper;
using ArtworkForShare.DAL.Abstract;
using ArtworkForShare.Model.Entities;
using ArtworkForShare.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtworkForShare.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL dAL)
        {
            userDAL = dAL;
        }
        void Check(User user)
        {
            string fullname = user.FirstName + user.LastName;
            foreach (char item in fullname)
            {
                if (item != ' ')
                {
                    if (!char.IsLetter(item))
                    {
                        throw new Exception("Ad ve soyad sadece harflerden oluşmalıdır.");
                    }
                }
            }
            foreach (char item in user.EMail)
            {
                if (item == ' ')
                {
                    throw new Exception("Email adresinde boşluk ' ' bırakmayınız.");
                }
            }
            if (!user.EMail.Contains('@') || !user.EMail.Contains(".com"))
            {
                throw new Exception("Lütfen e-mailinizi doğru formatta yazınız.(....@....com)");
            }
            if (user.Phone != null)
            {
                if (user.Phone.Length != 11)
                {
                    throw new Exception("Telefon numarası 11 haneli olmalıdır.");
                }
                foreach (char item in user.Phone)
                {
                    if (!char.IsDigit(item))
                    {
                        throw new Exception("Telefon numarası sadece sayılardan oluşmalıdır.");
                    }
                }

            }
        }
        void CheckUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.EMail) || string.IsNullOrWhiteSpace(user.UserName) || string.IsNullOrWhiteSpace(user.Password))
            {
                throw new Exception("*Bilgileri boş geçilemez.");
            }
        }
        void IsThereAny(User user)
        {
            foreach (string item in GetAllUsersName())
            {
                if (user.UserName == item)
                {
                    throw new Exception("Bu kullanıcı adı mevcut. Lütfen farklı bir kullanıcı adı giriniz.");
                }
            }
            foreach (string item in GetAllMails())
            {
                if (user.EMail == item)
                {
                    throw new Exception("Bu mail adresi mevcut. Lütfen farklı bir mail adresi giriniz.");
                }
            }
        }
        List<string> GetAllUsersName()
        {
            List<string> userNames = new List<string>();
            List<User> users = userDAL.GetAll().ToList();
            foreach (User item in users)
            {
                userNames.Add(item.UserName);
            }
            return userNames;
        }
        List<string> GetAllMails()
        {
            List<string> mails = new List<string>();
            List<User> users = userDAL.GetAll().ToList();
            foreach (User item in users)
            {
                mails.Add(item.EMail);
            }
            return mails;
        }
        void CheckUserName(User user)
        {
            if (user.UserName.Length > 30)
            {
                throw new Exception("Kullanıcı adı max 30 karakterden oluşmalıdır.");
            }
        }
        void CheckUserUpdate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.EMail) || string.IsNullOrWhiteSpace(user.UserName) || user.PasswordHash == null || user.PasswordSalt == null)
            {
                throw new Exception("*Bilgileri boş geçilemez.");
            }
        }
        public void Insert(User entity)
        {
            CheckUser(entity);
            Check(entity);
            CheckUserName(entity);
            IsThereAny(entity);
            byte[] _hash;
            byte[] _salt;
            PasswordHelperBLL.CreatePasswordHash(entity.Password, out _hash, out _salt);
            entity.PasswordHash = _hash;
            entity.PasswordSalt = _salt;
            userDAL.Add(entity);
        }
        public void Update(User entity)
        {
            Check(entity);
            //CheckUser(entity);
            CheckUserUpdate(entity);
            CheckUserName(entity);
            if (!string.IsNullOrWhiteSpace(entity.Password))
            {
                byte[] _hash;
                byte[] _salt;
                PasswordHelperBLL.CreatePasswordHash(entity.Password, out _hash, out _salt);
                entity.PasswordHash = _hash;
                entity.PasswordSalt = _salt;
            }
            userDAL.Update(entity);
        }

        public void Delete(User entity)
        {
            userDAL.Delete(entity);
        }

        public void DeleteById(int id)
        {
            User delete = Get(id);
            delete.IsActive = false;
            userDAL.Update(delete);
        }

        public User Get(int id)
        {
            return userDAL.Get(u => u.ID == id);
        }

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll(u => u.IsActive && u.ID != 1);
        }
        public User GetUserByActCode(Guid guid)
        {
            return userDAL.Get(u => u.ActivationCode == guid);
        }
        public User GetUserForLogin(string userName, string password)
        {
            User login = userDAL.Get(u => u.UserName == userName);
            if (login == null)
            {
                throw new Exception("Kullanıcı bilgileri yanlış.");
            }
            if (!login.IsActive)
            {
                throw new Exception("Hesabınızı henüz aktifleştirmediniz.Lütfen emailinize gönderilen activasyon linkine tıklayınız.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Lütfen şifre giriniz.");
            }
            bool result = PasswordHelperBLL.VerifyPasswordHash(password, login.PasswordHash, login.PasswordSalt);
            if (!result)
            {
                throw new Exception("Kullanıcı bilgileri yanlış.");
            }
            return login;
        }
        public User GetUserByUsername(string name)
        {
            return userDAL.Get(u => u.UserName == name);
        }
        public void UpdateProfile(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.EMail) || string.IsNullOrWhiteSpace(user.UserName))
            {
                throw new Exception("*Bilgileri boş geçilemez.");
            }
            Check(user);
            CheckUserName(user);
            userDAL.Update(user);
        }
        public void ChangePassword(int id, string OldPassword, string NewPassword)
        {
            if (string.IsNullOrWhiteSpace(OldPassword) || string.IsNullOrWhiteSpace(NewPassword))
            {
                throw new Exception("Şifrenizi değiştirmek için alanları doldurunuz.");
            }
            if (OldPassword == NewPassword)
            {
                throw new Exception("Eski ve yeni şifre aynı olamaz");
            }
            User user = Get(id);
            bool check = PasswordHelperBLL.VerifyPasswordHash(OldPassword, user.PasswordHash, user.PasswordSalt);
            if (!check)
            {
                throw new Exception("Eski şifre hatalı");
            }
            byte[] _hash;
            byte[] _salt;
            PasswordHelperBLL.CreatePasswordHash(NewPassword, out _hash, out _salt);
            user.PasswordHash = _hash;
            user.PasswordSalt = _salt;
            userDAL.Update(user);
        }
        public int CheckUserForPassword(string userName, string eMail, string firstName, string lastName)
        {
            User user = userDAL.Get(a => a.UserName == userName && a.EMail == eMail && a.FirstName == firstName && a.LastName == lastName);
            if (user == null)
            {
                throw new Exception("Lütfen bilgilerinizi kontrol ediniz.");
            }
            return user.ID;
        }
        public void ResetPassword(int uid, string password)
        {
            User user = Get(uid);
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadığı için şifre değiştirilemiyor daha sonra tekrar deneyiniz.");
            }
            byte[] _hash;
            byte[] _salt;
            PasswordHelperBLL.CreatePasswordHash(password, out _hash, out _salt);
            user.PasswordHash = _hash;
            user.PasswordSalt = _salt;
            userDAL.Update(user);
        }
        public ICollection<User> GetUsersByName(string text)
        {
            return userDAL.GetAll(a => a.IsActive && a.UserName.ToLower().Contains(text.ToLower()) && a.Role == UserRole.Standart);
        }
        public int CounterUsers()
        {
            return userDAL.GetAll(a => a.IsActive).Count();
        }
    }
}
