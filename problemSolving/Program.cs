﻿using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace problemSolving
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Beginner
            //1
            //Console.WriteLine(ProblemSolving.PrintHundred());
            //Console.WriteLine(ProblemSolving.IsEven(10)?"even":"Odd");
            //Console.WriteLine(ProblemSolving.CalcTon(525.5));
            //Console.WriteLine(ProblemSolving.FactorialN(10));
            //Console.WriteLine(ProblemSolving.Reverse(""));
            //Console.WriteLine(ProblemSolving.Palindrome("madam"));
            //7
            //Console.WriteLine(ProblemSolving.CountOfNumAndLetter("ma dam123"));
            //8
            //Console.WriteLine(ProblemSolving.MultiplicationForNum(3));
            //9
            //Console.WriteLine(ProblemSolving.GCD(20,12));
            //Console.WriteLine(ProblemSolving.GCDS(20,12));
            //Console.WriteLine(ProblemSolving.CountEvenNumbersInRange(10,20));
            //12
            //Console.WriteLine(ProblemSolving.SumDigits(444));
            //13
            //Console.WriteLine(ProblemSolving.FindPrimeNum(10,1));
            //Console.WriteLine(ProblemSolving.ReverseInt(625));
            // 15
            List<int> nums = new List<int> { 4,1,1,2,4,5,1};
            //Console.WriteLine(ProblemSolving.MaxNumber(nums));
            //Console.WriteLine(ProblemSolving.CountVowels("sayeid"));
            //Console.WriteLine(ProblemSolving.RemoveDuplication(nums));
            Console.WriteLine(ProblemSolving.Anagrams("aab", "aba") ?"Anagrams":"not anagrams");



            #endregion


        }
    }
}
