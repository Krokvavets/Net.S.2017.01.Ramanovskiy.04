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
        ///<summary>
        /// The method is looking for next bigger number 
        ///</summary>
        /// <param name="number">Initial value</param>
        ///<returns>next bigger number</returns>
        public static int NextBiggerNumber(this int number)
        {
            if (number < 0)
                throw new ArgumentException("negative value");

            int[] numberDigits = new int[number.ToString().Length];
            int[] digits = new int[numberDigits.Length];
            for (int i = 0; i < digits.Length; i++)
                digits.SetValue(-1, i);
            numberByDigits(number, numberDigits);


            for (int i = 0; i < numberDigits.Length - 1; i++)
            {
                if (numberDigits[i] > numberDigits[i + 1])
                {

                    digits[i] = numberDigits[i + 1];
                    Array.Sort(digits);
                    numberDigits[i + 1] = numberDigits[i];
                    numberDigits[i] = -1;
                    digits.Copy(numberDigits);
                    break;
                }
                else
                {
                    digits[i] = numberDigits[i];
                    numberDigits[i] = -1;
                }
            }

            Array.Reverse(numberDigits);
            int newNumber;
            if (!int.TryParse(String.Join("", numberDigits), out newNumber))
                return -1;
            return newNumber;

        }

        ///<summary>
        /// The method splits number by digits 
        ///</summary>
        /// <param name="number">input number</param>
        ///<param name="array">array of digits of number</param>
        private static void numberByDigits(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number % 10;
                number /= 10;
            }
        }
        ///<summary>
        /// The method copy element into array 
        ///</summary>
        /// <param name="arr1">copied array</param>
        ///<param name="array">output array</param>

        private static void Copy(this int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {

                if (arr2[i] == -1)
                    arr2[i] = arr1[arr2.Length - 1 - i];
            }
        }

    }
}
