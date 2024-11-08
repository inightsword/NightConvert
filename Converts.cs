using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace NightConvert
{
    internal class Converts
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        // Function to URL encode a string
        public static string UrlEncode(string value)
        {
            return WebUtility.UrlEncode(value);
        }

        // Function to URL decode a string
        public static string UrlDecode(string value)
        {
            return WebUtility.UrlDecode(value);
        }

        // Function to HEX encode a string
        public static string HexEncode(string value)
        {
            StringBuilder hex = new StringBuilder(value.Length * 2);
            foreach (char c in value)
            {
                hex.AppendFormat("{0:x2}", (int)c);
            }
            return hex.ToString();
        }

        // Function to HEX decode a string
        public static string HexDecode(string hexValue)
        {
            StringBuilder result = new StringBuilder(hexValue.Length / 2);
            for (int i = 0; i < hexValue.Length; i += 2)
            {
                string hexChar = hexValue.Substring(i, 2);
                result.Append((char)Convert.ToInt32(hexChar, 16));
            }
            return result.ToString();
        }

        public static string HtmlEncode(string value)
        {
            return WebUtility.HtmlEncode(value);
        }

        // Function to HTML decode a string
        public static string HtmlDecode(string value)
        {
            return WebUtility.HtmlDecode(value);
        }
        public static string ComputeMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert hash bytes to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static string ComputeSha1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert hash bytes to hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string EncryptString(string plainText, string key, string iv)
        {
            byte[] keyBytes = GetValidKey(key); // Ensure the key is valid for AES
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }

        // Function to decrypt a string using AES
        public static string DecryptString(string cipherText, string key, string iv)
        {
            byte[] keyBytes = GetValidKey(key); // Ensure the key is valid for AES
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] plainBytes = new byte[cipherText.Length];
                        int decryptedByteCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);
                        return Encoding.UTF8.GetString(plainBytes, 0, decryptedByteCount);
                    }
                }
            }
        }

        // Function to ensure the key is the correct length for AES
        private static byte[] GetValidKey(string key)
        {
            // Convert the key to bytes
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            // If the key is too short or too long, adjust it
            if (keyBytes.Length < 16)
            {
                // Pad the key with zeros if it's too short
                Array.Resize(ref keyBytes, 16);
            }
            else if (keyBytes.Length < 24)
            {
                // Pad the key with zeros if it's between 16 and 24 bytes
                Array.Resize(ref keyBytes, 24);
            }
            else if (keyBytes.Length < 32)
            {
                // Pad the key with zeros if it's between 24 and 32 bytes
                Array.Resize(ref keyBytes, 32);
            }

            // If it's too long, truncate it to 32 bytes (AES-256)
            if (keyBytes.Length > 32)
            {
                Array.Resize(ref keyBytes, 32);
            }

            return keyBytes;
        }

    }
}
