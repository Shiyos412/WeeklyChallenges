using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool a in vals)
            {
                if(a == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach(int a in numbers)
            {
                if(a % 2 != 0)
                {
                    sum += a;
                }
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool lower = false;
            bool upper = false;
            bool number = false;
            foreach(char a in password)
            {
                if(char.IsNumber(a) == true)
                {
                    number = true;
                }
                else if(char.IsUpper(a) == true)
                {
                    upper = true;
                }
                else if(char.IsLower(a) == true)
                {
                    lower = true;
                }

                    
            }
            if(lower && upper && number)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (val == " ")
            {
                return ' ';
            }
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (val == " ")
            {
                return ' ';
            }
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for(int i = 1; i < 100; i++)
            {
                if((i % 2) != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
