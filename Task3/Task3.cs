using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Task3
    {
        public static int NextBiggerNumber(this int number)
        {
            if (number < 0)
                throw new ArgumentException("negative value");
           
            char[] digitsChars = number.ToString().ToCharArray();
            int[] numberDigits = new int[digitsChars.Length];
            int[] digits = new int[digitsChars.Length];
            int chenchangingNumber = number;
            for (int i = 0; i < digitsChars.Length; i++)
            {
                numberDigits[i] = chenchangingNumber % 10;
                chenchangingNumber /= 10;
                digits[i] = -1;
            }

            int [] newNumberDigits = new int[numberDigits.Length];
            for (int i =0; i <numberDigits.Length-1; i++)
            {
                if (numberDigits[i] > numberDigits[i + 1])
                {
                    digits[i] = numberDigits[i + 1];
                    numberDigits[i + 1] = numberDigits[i];
                    numberDigits[i] = -1;
                    break;
                }
                else
                {
                    digits[i] = numberDigits[i];
                    numberDigits[i] = -1;
                }
            }

            Array.Sort(digits);
            newNumberDigits = (int[])numberDigits.Clone();
            for (int i = 0; i < newNumberDigits.Length; i++)
            {
                
                if (newNumberDigits[i] == -1 && digits[digits.Length-1-i] != -1)
                    newNumberDigits[i] = digits[digits.Length - 1 - i];
            }

            Array.Reverse(newNumberDigits);
            

            string stringNum = string.Empty;
            foreach (int digit in newNumberDigits)
            {
                stringNum += digit;
            }

            chenchangingNumber = int.Parse(stringNum);
            if (chenchangingNumber > number)
                return chenchangingNumber;
            return -1;
        }

    }
}
