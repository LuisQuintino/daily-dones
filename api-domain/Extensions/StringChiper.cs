using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Generators;

namespace api_domain.Extensions
{
    public static class StringCipher
    {
        private const int saltFactor = 16;

        public static string GenerateHash(string toGenerate)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            byte[] passwordBytes = Encoding.UTF8.GetBytes(toGenerate);

            byte[] hashBytes = BCrypt.Generate(passwordBytes, salt, saltFactor);

            string hash = Convert.ToBase64String(hashBytes);
            return hash;
        }

        public static bool CompareHash(string passwordHashed, string toCompare)
        {
            var hashFromCompare = GenerateHash(toCompare);
            byte[] hashBytes = Convert.FromBase64String(passwordHashed);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(hashFromCompare);
            bool isMatch = hashBytes.SequenceEqual(hashBytes);

            return isMatch;
        }
    }
}
