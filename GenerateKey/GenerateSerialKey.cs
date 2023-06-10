using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenerateKey
{
    public static class GenerateSerialKey
    {
        public static string GetSerialKey(string encryptSerial, string date)
        {
            var (Key, IVBase64) = InitSymmetricEncryptionKeyIV();
            string serial = Decrypt(encryptSerial, IVBase64, Key);
            //string date = "29072023";

            if (serial.Length > date.Length)
            {
                date = date.PadLeft(serial.Length, 'A');
            }
            else
            {
                serial = serial.PadLeft(date.Length, 'A');
            }

            char[] serialKey = new char[serial.Length * 2];
            for (int i = 0; i < serial.Length; i++)
            {
                int index = i * 2;
                serialKey[index] = serial[i];

                serialKey[index + 1] = date[i];
            }

            return Encrypt(new string(serialKey), IVBase64, Key);
        }

        private static (string Key, string IVBase64) InitSymmetricEncryptionKeyIV()
        {
            var key = "RpYUrq6iseYczkK9fjYruTHY1M7qP2qC6Y8FbQ4+52E=";
            var IVBase64 = "0T/j0PWSKHa68eOs42MkQw==";
            return (key, IVBase64);
        }

        private static Aes CreateCipher(string keyBase64)
        {
            Aes cipher = Aes.Create();
            cipher.Mode = CipherMode.CBC;

            cipher.Padding = PaddingMode.ISO10126;
            cipher.Key = Convert.FromBase64String(keyBase64);

            return cipher;
        }

        private static string Encrypt(string text, string IV, string key)
        {
            Aes cipher = CreateCipher(key);
            cipher.IV = Convert.FromBase64String(IV);

            ICryptoTransform cryptTransform = cipher.CreateEncryptor();
            byte[] plaintext = Encoding.UTF8.GetBytes(text);
            byte[] cipherText = cryptTransform.TransformFinalBlock(plaintext, 0, plaintext.Length);

            return Convert.ToBase64String(cipherText);
        }

        public static string Decrypt(string encryptedText, string IV, string key)
        {
            Aes cipher = CreateCipher(key);
            cipher.IV = Convert.FromBase64String(IV);

            ICryptoTransform cryptTransform = cipher.CreateDecryptor();
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] plainBytes = cryptTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
