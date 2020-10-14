using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                startNumber++;
            } while (startNumber % n != 0);
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        { 
            foreach(Business b in businesses) { 
                if(b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {   
            if(numbers.Length == 0 || numbers == null)
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
            bool foundEven = false;
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0 && foundEven == false)
                {
                    foundEven = true;
                } else if (foundEven)
                {
                    sum += numbers[i];
                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {   
            string sentence = "";
            for(int i = 0; i < words.Length; i++)
            {
                sentence += words[i];
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] new_elements = new double[elements.Count / 4];
           for(int i = 0; i < elements.Count/4; i++)
            {
                new_elements[i] = elements[(i * 4) + 3];
            }
            return new_elements;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
