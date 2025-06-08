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
                for (int i = 0; i < sintense.Length; i++)
                {
                    if (char.IsDigit(sintense[i]))
                    {
                        countNum++;
                    }
                    else if (char.IsLetter(sintense[i]))
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


        public static string MultiplicationForNum(int num)
        {
            //StringBuilder temp = new StringBuilder();
            //string temp = "";
            StringBuilder temp = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                temp.Append($"{i} * {num} = {i * num}\n");
            }
            return temp.ToString();
        }

        public static int GCD(int val1, int val2)
        {
            int gcd = 0;

            List<int> val1GCd = new();
            List<int> val2GCd = new();

            for (int i = 1; i <= val1; i++)
            {
                if (val1 % i == 0)
                {
                    val1GCd.Add(i);
                }
                continue;
            }

            for (int i = 1; i <= val2; i++)
            {
                if (val2 % i == 0)
                {
                    val2GCd.Add(i);
                }
                continue;
            }

            foreach (int num1 in val1GCd)
            {

                if (val2GCd.Contains(num1) && num1 > gcd)
                {
                    gcd = num1;
                }
            }

            return gcd;

        }

        public static int GCDS(int a, int b)
        {
            while (b != 0)
            {

                int temp = b;
                b = a % b;
                a = temp;
            }


            return a;
        }

        public static int CountEvenNumbersInRange(int a, int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;

            }

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
                continue;
            }


            return count;
        }

        public static int SumDigits(int num)
        {
            int sum = default;

            string numString = Convert.ToString(num);

            for (int i = 0; i < numString.Length; i++)
            {
                sum += numString[i] - '0';
            }

            return sum;

        }


        public static string? FindPrimeNum(int a, int b)
        {
            //if (a <= 1) return "fail,you should start from 2 or over 2";

            List<int> primeNums = new();

            for (int i = a; i <= b; i++)
            {
                if (i < 2) continue;

                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {

                        isPrime = false;

                    }

                }

                if (isPrime) { 
                
                primeNums.Add(i);

                }


            }


            string templates = String.Join(",", primeNums);

            return $"[{templates}]";



        }

    }
}
