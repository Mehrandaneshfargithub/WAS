using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenerateKey
{
    public static class EncryptConnectionString
    {
        public static string GetEncryptString(string connectionString)
        {
            var (Key, IVBase64) = InitSymmetricEncryptionKeyIV();

            return Encrypt(connectionString, IVBase64, Key);
        }

        static (string Key, string IVBase64) InitSymmetricEncryptionKeyIV()
        {
            var key = "B9SupmNM1gV/0nyli1qS3o5akkzFhO+CoqByEb0yU9A=";
            var IVBase64 = "dCsOgZ3hl3pe7RlRrH6Aig==";
            return (key, IVBase64);
        }

        private static Aes CreateCipher(string keyBase64)
        {
            // Default values: Keysize 256, Padding PKC27
            Aes cipher = Aes.Create();
            cipher.Mode = CipherMode.CBC;  // Ensure the integrity of the ciphertext if using CBC

            cipher.Padding = PaddingMode.ISO10126;
            cipher.Key = Convert.FromBase64String(keyBase64);

            return cipher;
        }

        static string Encrypt(string text, string IV, string key)
        {
            Aes cipher = CreateCipher(key);
            cipher.IV = Convert.FromBase64String(IV);

            ICryptoTransform cryptTransform = cipher.CreateEncryptor();
            byte[] plaintext = Encoding.UTF8.GetBytes(text);
            byte[] cipherText = cryptTransform.TransformFinalBlock(plaintext, 0, plaintext.Length);

            return Convert.ToBase64String(cipherText);
        }
    }
}
