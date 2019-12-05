using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1
{
    public static class Common
    {
        public static class RegexPattern
        {
            public static string Username = @"^[a-z][a-z0-9-_.]{2,}$";
            public static string Password = @"^[a-z0-9]{3,}$";
            public static string Name = @"^[a-zA-Z-_.].*";
            public static string Email = @"\b[\w\.-]+@[\w\.-]+\.\w{2,4}\b";
            public static string Dob = @"^(((0[1-9]|[12][0-9]|3[01])[- /.](0[13578]|1[02])|(0[1-9]|[12][0-9]|30)[- /.](0[469]|11)|(0[1-9]|1\d|2[0-8])[- /.]02)[- /.]\d{4}|29[- /.]02[- /.](\d{2}(0[48]|[2468][048]|[13579][26])|([02468][048]|[1359][26])00))$";
        }

        public static string HashPassword(string password)
        {
            // Get SHA1 provider
            var sha = new SHA1CryptoServiceProvider();

            // Get string password + get bytes string password
            var strPassword = password;
            var bufferPassword = ASCIIEncoding.ASCII.GetBytes(strPassword);

            // Get string salt (Time Now) + get bytes string salt
            var strTimeNow = DateTime.Now.Millisecond.ToString();
            var bufferTimeNow = ASCIIEncoding.ASCII.GetBytes(strTimeNow);

            // Create bytes password with salt
            var bufferPasswordSalt = new byte[bufferPassword.Length + bufferTimeNow.Length];
            Array.Copy(bufferPassword, bufferPasswordSalt, bufferPassword.Length);
            Array.Copy(bufferTimeNow, 0, bufferPasswordSalt, bufferPassword.Length, bufferTimeNow.Length);

            // Hash password salt
            var bufferPasswordHashed = sha.ComputeHash(bufferPasswordSalt);
            var bufferPasswordSaltHashed = new byte[bufferPasswordHashed.Length + bufferTimeNow.Length];
            // 
            Array.Copy(bufferPasswordHashed, bufferPasswordSaltHashed, bufferPasswordHashed.Length);
            Array.Copy(bufferTimeNow, 0, bufferPasswordSaltHashed, bufferPasswordHashed.Length, bufferTimeNow.Length);

            // Get string hashed
            var strPasswordSaltHashed = BitConverter.ToString(bufferPasswordSaltHashed).Replace("-", "");

            return strPasswordSaltHashed;
        }

        public static bool VerifyPassword(string password, string hashPassword)
        {
            int hashLength = 20;
            List<char> lHex = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7',
                                               '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

            // Get SHA1 provider
            var sha = new SHA1CryptoServiceProvider();

            // Get string password + get bytes string password
            var strPassword = password;
            var bufferPassword = ASCIIEncoding.ASCII.GetBytes(strPassword);

            // Get salt
            var arrChar = hashPassword.ToCharArray();
            var buffer = new byte[hashPassword.Length / 2 - hashLength];
            for (int i = hashLength * 2, j = 0; i < arrChar.Length; i += 2)
            {
                buffer[j++] = (byte)(lHex.IndexOf(arrChar[i]) * 16 + lHex.IndexOf(arrChar[i + 1]));
            }

            // Get bytes salt
            var bufferPasswordSalt = new byte[bufferPassword.Length + buffer.Length];
            Array.Copy(bufferPassword, bufferPasswordSalt, bufferPassword.Length);
            Array.Copy(buffer, 0, bufferPasswordSalt, bufferPassword.Length, buffer.Length);

            // Hash password salt
            var bufferPasswordHashed = sha.ComputeHash(bufferPasswordSalt);
            var bufferPasswordSaltHashed = new byte[bufferPasswordHashed.Length + buffer.Length];
            // 
            Array.Copy(bufferPasswordHashed, bufferPasswordSaltHashed, bufferPasswordHashed.Length);
            Array.Copy(buffer, 0, bufferPasswordSaltHashed, bufferPasswordHashed.Length, buffer.Length);

            // Get string hashed
            var strPasswordSaltHashed = BitConverter.ToString(bufferPasswordSaltHashed).Replace("-", "");

            if (strPasswordSaltHashed == hashPassword)
            {
                return true;
            }

            return false;
        }
    }
}
