using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Extensions
{
    public class CustomExstension
    {
        public char[] Numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public bool IsNumber(string str)
        {
            var dots = 0;

            foreach(var character in str)
            {
                if(character == '.') dots++;
                if (Numbers.Contains(character)) continue;
                else return false;
            }
            return true;
        }

        //public bool IsDate(string str) { }
        
        public string[] ToWords(string str) {
            return str.Split(' ');
        }

        public string CalculateHash(string str)
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

        public void SaveToFile(string filePath, string fileText)
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

        public double ToPercent(double num)
        {
            if (num < 0 || num > 1) throw new Exception("number should be in [0, 1] interval");

            return num * 100;

        }

        
        /*
         * It would more convenient if I would use Round function just tried to invent a wheel again..
         */
        public int RoundDown(double num)
        {
            double division = Convert.ToInt32(num) / num;
            int roundedDown = Convert.ToInt32(num);
            if (division > 1) roundedDown--;
            return roundedDown;
        }

        public decimal ToDecimal(double num)
        {
            return Convert.ToDecimal(num);
        }


        public bool IsGreater(double number, double numberTwo)
        {
            if (number > numberTwo) return true;
            return false;
        }

        public bool IsLess(double number, double numberTwo)
        {
            if (number < numberTwo) return true;
            return false;
        }

        public DateTime Min(DateTime dateOne, DateTime dateTwo)
        {
            return Min(dateOne, dateTwo);
        }

        public DateTime Max(DateTime dateOne, DateTime dateTwo)
        {
            return Max(dateOne, dateTwo);
        }

        public DateTime BeginingOfMonth(DateTime date)
        {
            var newDate = new DateTime(date.Year, date.Month, 1);
            Console.WriteLine();
            return newDate;
        }

        public DateTime EndOfMonth(DateTime date)
        {
            DateTime endOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)); 
            return endOfMonth;
        }

    }
}
