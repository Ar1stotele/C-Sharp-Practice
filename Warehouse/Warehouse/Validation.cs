using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseNamespace
{
    public class Validation
    {

        public static bool CheckWhitespaceInStartAndEnd(string name)
        {
            if (name[0] == ' ') return true;
            if (name[name.Length - 1] == ' ') return true;
            return false;
        }

        public static bool CheckIfStartsWithNumber(string name)
        {
            var numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (var number in numbers)
            {
                if (name.StartsWith(number)) return true;
            }
            return false;
        }

        public void NameValidation(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name");
            }

            if (CheckIfStartsWithNumber(name))
            {
                throw new ArgumentException("name");
            }

            if (name.Length > 50)
            {
                throw new ArgumentOutOfRangeException("name");
            }

            if (CheckWhitespaceInStartAndEnd(name))
            {
                throw new ArgumentException("name");
            }

        }
    }
}
