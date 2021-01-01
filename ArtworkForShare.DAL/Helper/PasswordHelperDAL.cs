using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ArtworkForShare.DAL.Helper
{
     class PasswordHelperDAL
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
