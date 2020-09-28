using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                return vals.Contains(false);
            }

            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }
               

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
            {
                return false;
            }
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1]; 
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
            int last = nums[nums.Length - 1];
            int first = nums[0];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    odds[count] = i;
                    count++;
                }

            }
            return odds;
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
 