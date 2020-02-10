using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber % n == 0)
            {
                return startNumber + n;
            }
            else
            {
                return (startNumber) + (n - (startNumber % n));
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business a in businesses)
            {
                if(a.TotalRevenue == 0)
                {
                    a.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers == Array.Empty<int>())
            {
                return false;
            }
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers == Array.Empty<int>())
            {
                return 0;
            }
            int sum = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words == Array.Empty<string>())
            {
                return "";
            }
            bool isEmpty = true;
            foreach (string k in words)
            {
                if(k != " ")
                {
                    isEmpty = false;
                }
            }
            if(isEmpty == true)
            {
                return "";
            }
            List<string> results = new List<string>();
            foreach (string a in words)
            {
                if (a == " ")
                {
                    results.Add("");
                }
                else
                {
                    results.Add(a.Trim());
                }

            }
            string end = "";
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] == (""))
                {
                    Console.Write("Found it");

                }
                if (i + 1 == results.Count)
                {
                    end += $"{results[i]}.";
                }
                else if (results[i] != (""))
                {
                    end += $"{results[i]} ";
                }
            }

            return end;
        }
       

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null)
            {
                return new double[0];
            }
            var result = new List<double>();
            if(elements.Count < 4)
            {
                return new double[0];
            }
            
            for (int i = 3; i < elements.Count; i+=4) 
            {
                result.Add(elements[i]);
                
            }
            return result.ToArray() ;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
