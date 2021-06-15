/*
MIT LICENSE

Copyright 2017 Digital Ruby, LLC - http://www.digitalruby.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace ActivWpf.Utils
{
    /// <summary>
    /// Useful extension methods for all sorts of things. Who says a kitchen sink class is bad?
    /// </summary>
    public static class CryptoUtility
    {
        internal static readonly Encoding Utf8EncodingNoPrefix = new UTF8Encoding(false, true);
        public static Encoding UTF8EncodingNoPrefix { get { return Utf8EncodingNoPrefix; } }

        /// <summary>
        /// AES decrypt data with a password and salt
        /// </summary>
        /// <param name="input">Data to decrypt</param>
        /// <param name="password">Password</param>
        /// <param name="salt">Salt</param>
        /// <returns>Decrypted data</returns>
        public static byte[]? AesDecryption(byte[] input, byte[] password, byte[] salt)
        {
            if (input == null || input.Length == 0 || password == null || password.Length == 0 || salt == null || salt.Length == 0)
            {
                return null;
            }
            MemoryStream decrypted = new MemoryStream();
            using (RijndaelManaged AES = new RijndaelManaged()
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
            })
            {
                var key = new Rfc2898DeriveBytes(password, salt, 1024);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CBC;
                MemoryStream encrypted = new MemoryStream(input);
                byte[] saltMatch = new byte[salt.Length];
                if (encrypted.Read(saltMatch, 0, saltMatch.Length) != salt.Length || !salt.SequenceEqual(saltMatch))
                {
                    throw new InvalidOperationException("Invalid salt");
                }
                var cs = new CryptoStream(encrypted, AES.CreateDecryptor(), CryptoStreamMode.Read);
                byte[] buffer = new byte[8192];
                int count;
                while ((count = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    decrypted.Write(buffer, 0, count);
                }
                return decrypted.ToArray();
            }
        }

        /// <summary>
        /// AES encrypt data with a password and salt
        /// </summary>
        /// <param name="input">Data to encrypt</param>
        /// <param name="password">Password</param>
        /// <param name="salt">Salt</param>
        /// <returns>Encrypted data</returns>
        public static byte[] AesEncryption(byte[] input, byte[] password, byte[] salt)
        {
            if (input == null || input.Length == 0 || password == null || password.Length == 0 || salt == null || salt.Length == 0)
            {
                return null;
            }
            var encrypted = new MemoryStream();
            var AES = new RijndaelManaged()
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
            };
            var key = new Rfc2898DeriveBytes(password, salt, 1024);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CBC;
            encrypted.Write(salt, 0, salt.Length);
            var cs = new CryptoStream(encrypted, AES.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.FlushFinalBlock();
            return encrypted.ToArray();
        }

        /// <summary>
        /// Load protected data as strings from file. Call this function in your production environment, loading in a securely encrypted file which will stay encrypted in memory.
        /// </summary>
        /// <param name="path">Path to load from</param>
        /// <returns>Protected data</returns>
        public static SecureString[] LoadProtectedStringsFromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);

            // while unprotectedBytes is populated, app is vulnerable - we clear this array ASAP to remove sensitive data from memory
            var unprotectedBytes = DataProtector.Unprotect(bytes);

            using var memory = new MemoryStream(unprotectedBytes);
            using var reader = new BinaryReader(memory, Encoding.UTF8);
            var strings = new List<SecureString>();

            while (memory.Position != memory.Length)
            {
                // copy char by char into secure string to avoid making additional string copies of sensitive data
                var current = new SecureString();
                strings.Add(current);
                var len = reader.ReadInt32();
                while (len-- > 0)
                {
                    current.AppendChar(reader.ReadChar());
                }
            }

            // cleanup and zero it out, hopefully GC hasn't moved unprotectedBytes around in memory
            Array.Clear(bytes, 0, bytes.Length);
            Array.Clear(unprotectedBytes, 0, unprotectedBytes.Length);

            return strings.ToArray();
        }

        /// <summary>
        /// Save unprotected data as strings to a file, where it will be encrypted for the current user account. Call this method offline with the data you need to secure.
        /// Call CryptoUtility.LoadProtectedStringsFromFile to later load these strings from the file.
        /// </summary>
        /// <param name="path">Path to save to</param>
        /// <param name="strings">Strings to save.</param>
        /// <example><![CDATA[
        /// CryptoUtility.SaveUnprotectedStringsToFile("test.bin", new string[] { "my super secret user name", "my super secret password with a ❤heart" });
        /// SecureString[] secure = CryptoUtility.LoadProtectedStringsFromFile("test.bin");
        /// string s;
        /// for (int i = 0; i<secure.Length; i++)
        /// {
        ///     s = CryptoUtility.SecureStringToString(secure[i]);
        ///     Console.WriteLine(s);
        /// }
        /// Console.ReadLine();
        /// ]]></example>
        public static void SaveUnprotectedStringsToFile(string path, params string[] strings)
        {
            MemoryStream memory = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memory, Encoding.UTF8);
            char[] chars;
            foreach (string s in strings)
            {
                chars = s.ToArray();
                writer.Write(chars.Length);
                foreach (char c in chars)
                {
                    writer.Write(c);
                }
            }
            writer.Flush();
            File.WriteAllBytes(path, DataProtector.Protect(memory.ToArray()));
        }

        /// <summary>
        /// Get utf-8 bytes from a string
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>UTF8 bytes or null if s is null</returns>
        public static byte[] ToBytesUTF8(this string s)
        {
            if (s == null)
            {
                return null;
            }
            return Utf8EncodingNoPrefix.GetBytes(s);
        }

        /// <summary>
        /// Covnert a secure string to a non-secure string
        /// </summary>
        /// <param name="s">SecureString</param>
        /// <returns>Non-secure string</returns>
        public static string ToUnsecureString(this SecureString s)
        {
            if (s == null)
            {
                return null;
            }
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(s);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public static bool IsWindows { get; } = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    }
}
