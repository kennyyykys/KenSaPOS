using System;
using System.Security.Cryptography;
using System.Text;

namespace KenSaPOS.Data
{
    /// <summary>
    /// Matches the database seed: PasswordHash = SHA-256( Salt + Password ) as uppercase hex.
    /// </summary>
    public static class PasswordHasher
    {
        public static string Hash(string salt, string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
                var sb = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        public static string NewSalt()
        {
            var bytes = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            var sb = new StringBuilder(32);
            foreach (byte b in bytes) sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        public static bool Verify(string salt, string password, string expectedHash)
        {
            if (salt == null || password == null || expectedHash == null) return false;
            string actual = Hash(salt, password).ToUpperInvariant();
            string expected = expectedHash.Trim().ToUpperInvariant();
            if (actual.Length != expected.Length) return false;

            int diff = 0;                       // constant-time comparison
            for (int i = 0; i < actual.Length; i++) diff |= actual[i] ^ expected[i];
            return diff == 0;
        }
    }
}
