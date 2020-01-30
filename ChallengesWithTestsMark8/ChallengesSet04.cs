using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
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
                else
                {
                    sum -= a;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int length = str1.Length;
            if(str2.Length < length)
            {
                length = str2.Length;
            }
            if(str3.Length < length)
            {
                length = str3.Length;
            }
            if(str4.Length < length)
            {
                length = str4.Length;
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int min = number1;
            if(number2 < min)
            {
                min = number2;
            }
            if(number3 < min)
            {
                min = number3;
            }
            if(number4 < min)
            {
                min = number4;
            }
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0)
            {
                return false;
            }
            if(sideLength1 + sideLength2 > sideLength3)
            {
                if(sideLength2 + sideLength3 > sideLength1)
                {
                    if(sideLength1 + sideLength3 > sideLength2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double a;
            return double.TryParse(input, out a);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            double half;
            if(objs.Length % 2 != 0)
            {
                half = objs.Length / 2;
            }
            else
            {
                half = objs.Length / 2;
            }
            int count = 0;
            foreach(object a in objs)
            {
                if(a == null)
                {
                    count++;
                }
            }
            return ((double)count > half);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == Array.Empty<int>() || numbers == null)
            {
                return 0;
            }
            double sum = 0;
            double count = 0;
            foreach(int a in numbers)
            {
                if(a % 2 == 0)
                {
                    sum += a;
                    count++;

                }
            }
            if(count == 0)
            {
                return 0;
            }
            return (sum / count);
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(number == 0)
            {
                return 1;
            }
            else if(number == 1)
            {
                return 1;
            }
            int sum = 1;
            for(int i = number; i > 0; i--)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
