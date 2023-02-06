using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Extensions
{
    public static class CustomExstension
    {
        public static bool IsNumber(this string str)
        {
        var numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        var dots = 0;

            foreach(var character in str)
            {
                if(character == '.') dots++;
                if (numbers.Contains(character)) continue;
                else return false;
            }
            return true;
        }

        public static bool IsDate(this string str) {
            var value = new DateTime();
            var isDateTime = DateTime.TryParse(str, out value);
            return isDateTime;
        }

        public static string[] ToWords(this string str) {
            return str.Split(' ');
        }

        public static string CalculateHash(this string str)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static void SaveToFile(this string filePath, string fileText)
        {
            filePath = filePath.Replace(@"/", @"\");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // Create a new file     
            using (FileStream fs = File.Create(filePath))
            {
                // Add some text to file    
                Byte[] title = new UTF8Encoding(true).GetBytes(fileText);
                fs.Write(title, 0, title.Length);
            }
        }

        public static double ToPercent(this double num)
        {
            if (num < 0 || num > 1) throw new Exception("number should be in [0, 1] interval");

            return num * 100;
        }

        
        public static int RoundDown(this double num)
        {
            return (int)num;
        }

        public static decimal ToDecimal(this double num)
        {
            return Convert.ToDecimal(num);
        }


        public static bool IsGreater(this double number, double numberTwo)
        {
            return number > numberTwo;
        }

        public static bool IsLess(this double number, double numberTwo)
        {
            return number < numberTwo;
        }

        public static DateTime Min(this DateTime dateOne, DateTime dateTwo)
        {
            return Min(dateOne, dateTwo);
        }

        public static DateTime Max(this DateTime dateOne, DateTime dateTwo)
        {
            return Max(dateOne, dateTwo);
        }

        public static DateTime BeginingOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime EndOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

    }
}
