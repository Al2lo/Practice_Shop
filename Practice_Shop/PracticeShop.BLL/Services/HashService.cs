using System.Security.Cryptography;
using System.Text;
using PracticeShop.BLL.Services.Interfaces;

namespace PracticeShop.BLL.Services
{
    public class HashService : IHashService
    {
        private readonly int keySize = 64;
        private readonly int iterations = 10000;
        private readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA256;
        public string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
               Encoding.UTF8.GetBytes(password),
               salt,
               iterations,
               hashAlgorithm,
               keySize);
            return Convert.ToHexString(hash);

        }

        public bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
