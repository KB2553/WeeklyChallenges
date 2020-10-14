using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            foreach(string w in words)
            {
                if (ignoreCase && w.Equals(word, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                } else if (!ignoreCase && w.Equals(word))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int q = -1;
            for(int i = 0; i < str.Length; i++)
            {
                bool found = false;
                for(int j = 0; j < str.Length; j++)
                {
                    if(str[j] == str[i] && j != i)
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    q = i;
                }
            }
            return q;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max_count = 0;
            int count = 1;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] > numbers[i + 1])
                {
                    count++;
                    if(count > max_count)
                    {
                        max_count = count;
                    }
                } else
                {
                    count = 1;
                }
            }
            return max_count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] arr = new double[elements.Count/n];
            for(int i = 0; i < elements.Count/n; i++)
            {
                arr[i] = arr[i * n + (n - 1)];
            }
            return arr;

        }
    }
}
