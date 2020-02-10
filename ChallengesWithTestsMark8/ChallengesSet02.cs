﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            
            if(vals.Length%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            if(numbers.Count() == 0)
            {
                return 0;
            }
            double min = (double)Enumerable.Min(numbers);
            double max = (double)Enumerable.Max(numbers);
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach(int a in numbers)
            {
                sum += a;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach(int a in numbers)
            {
                if(a % 2 == 0)
                {
                    sum += a;
                }
            }
            //return sum;

            var sum2 = numbers.Where(num => num % 2 == 0).Sum();
            return sum2;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach(int a in numbers)
            {
                sum += a;
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
