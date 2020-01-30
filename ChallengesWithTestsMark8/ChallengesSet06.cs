using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null)
            {
                return false;
            }
            foreach(string a in words)
            {
                if(a == null)
                {
                    return false;
                }
            }
            if(ignoreCase == true)
            {
                foreach(string a in words)
                {
                    if(a.ToUpper() == word.ToUpper())
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach(string a in words)
                {
                    if(a == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num < 0)
            {
                return false;
            }
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0 && i != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = 1001;
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                count = 0;
                foreach(char a in str)
                {
                    if(str[i] == a)
                    {
                        count++;
                    }
                }
                if(count < 2)
                {
                    index = i;
                }
                
            }
            if(index == 1001)
            {
                return -1;
            }
            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int max = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                for(int j = i; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        count++;
                    }
                    else if(numbers[i] != numbers[j])
                    {
                        break;
                    }
                }
                if(count > max)
                {
                    max = count;
                }
            }
            return max;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == new List<double>())
            {
                return new double[0];
            }
            if(elements == null || n <= 0)
            {
                return new double[0];
            }
            if(elements.Count < n)
            {
                return new double[0];
            }
            double[] results = new double[elements.Count / n];
            int index = 0;
            for(int i = n - 1; i < elements.Count; i += n)
            {
                results[index] = elements[i];
                index++;
            }
            return results;
        }
    }
}
