using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count += numbers[i];
                }
                else
                {
                    count -= numbers[i];
                }
            }
            return count;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int len3 = str3.Length;
            int len4 = str4.Length;

            return GetSmallestNumber(len1, len2, len3, len4);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
                int[] arr = { number1, number2, number3, number4 };
                int minimum = 2147483647;
                for(int i = 0; i < 4; i++)
                {
                    if(arr[i] < minimum)
                    {
                        minimum = arr[i];
                    }
                }
                return minimum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)  
        {
                biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {       

                if(sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 < 0)
                {
                    return false;
                }

                if(sideLength1 > sideLength2 && sideLength1 > sideLength3)
                {
                return sideLength1 > (sideLength2 + sideLength3);
                }
                if (sideLength2 > sideLength3 && sideLength2 > sideLength1)
                {
                    return sideLength2 > (sideLength3 + sideLength1);
                }
                if (sideLength3 > sideLength2 && sideLength3 > sideLength1)
                {
                    return sideLength3 > (sideLength2 + sideLength1);
                }

                return false;
        }

        public bool IsStringANumber(string input)
        {
                try
                {   

                    float numVal = float.Parse(input);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }

               
          }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
                int count = 0;
                for(int i = 0; i < objs.Length; i++){
                    if(objs[i] == null)
                    {
                        count += 1;
                    }
                }
            return (objs.Length / 2 < count);
        }

        public double AverageEvens(int[] numbers)
        {       
                if(numbers == null)
                {
                    return 0;
                }
                double count = 0;
                double evenSum = 0;

                
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 2 == 0)
                    {
                        count++;
                        evenSum += numbers[i];
                    }
                }

                if(numbers.Length == 0 || count == 0 )
                {
                    return 0;
                }


                return evenSum / count;

        }

        public int Factorial(int number)
        {       
                if(number < 0)
                 {
                    throw new ArgumentOutOfRangeException();
                }
                int fact = 1;
                for(int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                return fact;
        }
    }
}
