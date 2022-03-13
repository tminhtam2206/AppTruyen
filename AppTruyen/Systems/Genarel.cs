using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppTruyen.Systems
{
    public class Genarel
    {
        public static int ID = 0;
        public static string USER = "";
        public static int ID_TRUYEN = 0;
        public static string NAME_TRUYEN = "";
        public static int ID_CHUONG = 0;
        public static int NUM_CHUONG = 0;
        public static string NAME_CHUONG = "";
        public static string DATA_TEMP = "";
        public static bool CLOSE_FORM_TRUYEN = false;
        public static string VERSION = " [v2022.02.19]";
        public static bool PLAY_BACKGROUND = false;
        //Clipboard
        public static string CLIPBOARD = "";
        public static int MAX_LENGTH = 1600;

        public static string ConvertVersion(string str)
        {
            str = str.Replace(" ", String.Empty);
            str = str.Replace("[", String.Empty);
            str = str.Replace("]", String.Empty);
            return str;
        }

        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static int CountWords(string str)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int count = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        public static string DecodeFromUtf8(string utf8String)
        {
            // copy the string as UTF-8 bytes.
            byte[] utf8Bytes = new byte[utf8String.Length];
            for (int i = 0; i < utf8String.Length; ++i)
            {
                //Debug.Assert( 0 <= utf8String[i] && utf8String[i] <= 255, "the char must be in byte's range");
                utf8Bytes[i] = (byte)utf8String[i];
            }

            return Encoding.UTF8.GetString(utf8Bytes, 0, utf8Bytes.Length);
        }

        public static string LoadContent(string data)
        {
            return data.Replace("<br />", "\n");
        }

        public static string SaveContent(string data)
        {
            return data.Replace("\n", "<br />");
        }

        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string GenerateSlug(string str)
        {
            str = str.ToLower();

            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str.Replace(" ", "-");
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string NumToText(int _number)
        {
            if(_number.ToString().Length >= 4)
            {
                string[] str_num = new string[_number.ToString().Length];
                int _temp = _number;

                int i = 0;
                while (_number > 0)
                {
                    str_num[i] = (_number % 10).ToString();
                    _number /= 10;
                    i++;
                }
                
                //1000
                if(str_num.Length == 4)
                {
                    return str_num[str_num.Length - 1] + "." + str_num[str_num.Length - 2] + "K chữ";
                }
                //10.000
                else if(str_num.Length == 5)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + "." + str_num[str_num.Length - 3] + "K chữ";
                }
                //100.000
                else if (str_num.Length == 6)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + "." + str_num[str_num.Length - 4] + "K chữ";
                }
                //1.000.000
                else if (str_num.Length == 6)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + "." + str_num[str_num.Length - 5] + "Tr chữ";
                }
                //10.000.000
                else if (str_num.Length == 7)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + str_num[str_num.Length - 5] + "." + str_num[str_num.Length - 6] + "Tr chữ";
                }
                //100.000.000
                else if (str_num.Length == 8)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + str_num[str_num.Length - 5] + str_num[str_num.Length - 6] + "." + str_num[str_num.Length - 7] + "Tr chữ";
                }
                //1.000.000.000
                else if (str_num.Length == 9)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + str_num[str_num.Length - 5] + str_num[str_num.Length - 6] + str_num[str_num.Length - 7] + "." + str_num[str_num.Length - 8] + "Tỷ chữ";
                }
                //10.000.000.000
                else if (str_num.Length == 10)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + str_num[str_num.Length - 5] + str_num[str_num.Length - 6] + str_num[str_num.Length - 7] + str_num[str_num.Length - 8] + "." + str_num[str_num.Length - 9] + "Tỷ chữ";
                }
                //100.000.000.000
                else if (str_num.Length == 11)
                {
                    return str_num[str_num.Length - 1] + str_num[str_num.Length - 2] + str_num[str_num.Length - 3] + str_num[str_num.Length - 4] + str_num[str_num.Length - 5] + str_num[str_num.Length - 6] + str_num[str_num.Length - 7] + str_num[str_num.Length - 8] + str_num[str_num.Length - 9] + "." + str_num[str_num.Length - 10] + "Tỷ chữ";
                }
            }
            
            return _number.ToString();
        }
    }
}
