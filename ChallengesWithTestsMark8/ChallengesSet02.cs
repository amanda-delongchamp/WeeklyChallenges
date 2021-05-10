using System;
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
            if (vals.Length % 2 == 0)
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
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() <= 0)
            {
                return 0;
            }
            {
                return numbers.Min() + numbers.Max();
            }           
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                    
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    sum += num;
                }
            }
            else
            {
                return false;
            }

            if (sum % 2 != 0)
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
            long count = 0;

            for (int i = 0; i < number; i++)
            {
                if (i >= 0 && i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
