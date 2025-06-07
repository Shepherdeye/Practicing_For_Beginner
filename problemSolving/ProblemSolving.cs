using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    internal class ProblemSolving
    {


        public static string PrintHundred()
        {
            List<string> nums = new List<string>();

            for (int i = 1; i <= 100; i++)
            {

                nums.Add(i.ToString());

            }

            return $"[ {String.Join(",", nums)} ]";
        }

        public static bool IsEven(double num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            return false;

        }

        public static double CalcTon(double n)
        {
            double sum = 0.0;

            for (int i = 1; i <= Math.Floor(n); i++)
            {
                sum += i;

            }

            return sum;


        }

        public static string FactorialN(int n)
        {

            if (n == null) return "";

            double result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return $"Factorial of {n} is {result}";
        }

        public static string? Reverse(string temp)
        {

            if (string.IsNullOrEmpty(temp)) return null;

            string newTemp = "";

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (temp[i] == ' ')
                {
                    continue;
                }


                newTemp += temp[i];
            }

            return newTemp;

        }

        public static bool Palindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            StringBuilder reverseS = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverseS.Append(s[i]);
            }

            if (s.ToLower() == reverseS.ToString().ToLower())
                return true;
            else return false;


        }

        public static string? CountOfNumAndLetter(string sintense)
        {

            if (!string.IsNullOrEmpty(sintense))
            {
                int countNum = 0;
                int countLetter = 0;
                for(int i = 0; i<sintense.Length;i++)
                {
                    if (char.IsDigit(sintense[i]))
                    {
                        countNum++;
                    }else if (char.IsLetter(sintense[i]))
                    {
                        countLetter++;
                    }
                    else
                    {
                        continue;
                    }
                }

                return $"Count of Letters:{countLetter}\nCount of Numbers:{countNum}";
            }

            return null;
        }

    }
}
