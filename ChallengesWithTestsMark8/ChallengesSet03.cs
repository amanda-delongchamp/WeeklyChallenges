using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }

                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }

              

            }
            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var letters = val.ToCharArray();

            char firstLetter = letters[0];

            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            var letters = val.ToCharArray();

            char lastLetter = letters[val.Length -1];

            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            
                return dividend / divisor;
            
            
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = 0;
            int first = 0;

            /*for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    first = nums[i];
                }
                if (nums[i] == nums.Length - 1)
                {
                    last = nums[i];
                }
            }*/

            last = nums[nums.Length - 1];
            first = nums[0];

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
