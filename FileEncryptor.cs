using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace voenka
{
    public static class FileEncryptor
    {
        private static readonly string EncryptionKey = "YourStrongEncryptionKey123!";

        public static string DecryptFile(string encryptedFilePath)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = GetEncryptionKey(EncryptionKey);
                aes.IV = new byte[16];

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var encryptedFileStream = new FileStream(encryptedFilePath, FileMode.Open))
                using (var cryptoStream = new CryptoStream(encryptedFileStream, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(cryptoStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private static byte[] GetEncryptionKey(string key)
        {
            const int keySize = 16; // Выберите 16, 24 или 32 для AES
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            if (keyBytes.Length > keySize)
            {
                Array.Resize(ref keyBytes, keySize);
            }
            else if (keyBytes.Length < keySize)
            {
                byte[] paddedKey = new byte[keySize];
                Array.Copy(keyBytes, paddedKey, keyBytes.Length);
                keyBytes = paddedKey;
            }

            return keyBytes;
        }
    }
}
