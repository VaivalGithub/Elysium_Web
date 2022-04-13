using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SHARED
{
    public static class Encryption
    {
        public static IConfigurationRoot Configuration { get; set; }
        public static String strPermutation = GetAppSettingValues("StaticThings", "SecretKey");
        public const Int32 bytePermutation1 = 0x19;
        public const Int32 bytePermutation2 = 0x59;
        public const Int32 bytePermutation3 = 0x17;
        public const Int32 bytePermutation4 = 0x41;

        public static string Encrypt(string strData)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));
        }

        public static string Decrypt(string strData)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(strData)));
        }

        private static byte[] Encrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(strPermutation,
            new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }
        private static byte[] Decrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(strPermutation,
            new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        public static string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        public static string Create_SHA512Hash(string Input)
        {
            // Create a SHA512   
            using (SHA512 SHA512 = SHA512.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = SHA512.ComputeHash(Encoding.UTF8.GetBytes(Input));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        public static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public static string GetAppSettingValues(string Section, string Key)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration.GetSection(Section).GetSection(Key).Value;
        }

        public static string EncryptWithSecret(string str,string key)
        {
            try
            {

                var strData = Encoding.UTF8.GetBytes(str);
                PasswordDeriveBytes passbytes =
                new PasswordDeriveBytes(key,
                new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
                });

                MemoryStream memstream = new MemoryStream();
                Aes aes = new AesManaged();
                aes.Key = passbytes.GetBytes(aes.KeySize / 8);
                aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

                CryptoStream cryptostream = new CryptoStream(memstream,
                aes.CreateEncryptor(), CryptoStreamMode.Write);
                cryptostream.Write(strData, 0, strData.Length);
                cryptostream.Close();
                return Convert.ToBase64String(memstream.ToArray());
            }
            catch(Exception ex)
            {
                return "";
            }
        }
        public static string DecryptWithSecret(string str, string key)
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    var strData = Convert.FromBase64String(str);
                    PasswordDeriveBytes passbytes =
                    new PasswordDeriveBytes(key,
                    new byte[] { bytePermutation1,
                         bytePermutation2,
                         bytePermutation3,
                         bytePermutation4
                    });

                    MemoryStream memstream = new MemoryStream();
                    Aes aes = new AesManaged();
                    aes.Key = passbytes.GetBytes(aes.KeySize / 8);
                    aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

                    CryptoStream cryptostream = new CryptoStream(memstream,
                    aes.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptostream.Write(strData, 0, strData.Length);
                    cryptostream.Close();
                    return Encoding.UTF8.GetString(memstream.ToArray());
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
