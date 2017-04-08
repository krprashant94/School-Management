using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Encryption
    {
        private static string[] ones = {
    "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", 
    "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
};
        private static string[] tens = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static string[] thous = { "Hundred", "Thousand", "Million", "Billion", "Trillion", "Quadrillion" };

        public String md5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public string ToWords(decimal number)
        {
            int intPortion = (int)number;
            int decPortion = (int)((number - intPortion) * (decimal)100);
            return string.Format("₹ {0} Rupees and {1} Paisa", ToWords(intPortion), ToWords(decPortion));

        }
        public string ToWords(int number, string appendScale = "")
        {
            string numString = "";
            if (number < 100)
            {
                if (number < 20)
                    numString = ones[number];
                else
                {
                    numString = tens[number / 10];
                    if ((number % 10) > 0)
                        numString += "-" + ones[number % 10];
                }
            }
            else
            {
                int pow = 0;
                string powStr = "";

                if (number < 1000) // number is between 100 and 1000
                {
                    pow = 100;
                    powStr = thous[0];
                }
                else // find the scale of the number
                {
                    int log = (int)Math.Log(number, 1000);
                    pow = (int)Math.Pow(1000, log);
                    powStr = thous[log];
                }

                numString = string.Format("{0} {1}", ToWords(number / pow, powStr), ToWords(number % pow)).Trim();
            }

            return string.Format("{0} {1}", numString, appendScale).Trim();
        }
    }
}
