using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class CustomMath
    {
        public int SumOfOddNumbers(int[] array) 
        {
            //int sum = 0;

            //foreach (int item in array) 
            //{
            //    if (item % 2 != 0) 
            //    {
            //        sum += item;
                
            //    }
            
            //}

            //return sum;

            //return array.Where(m => m > 0).Sum(m => m);   
        }

        public string CheckNumOddOrEven(int number) 
        {
          //if (number % 2 == 0)
          //  {
          //      return "Even";

          //      return "Odd";

        } /*return number % 2 == 0 ? "Even" : "Odd";*/

        public double FindPowIfEvenNumbers(int[] numbers) => Math.Pow(snumbers.Where(x => x % 2 == 0).Sum(x => x), 2);

        public int Getfactorial(int num) 
        {
            int result = 1;

            for (int i = 1; i <= num; i++) 
            {
                result *= i;
            
            }
        return result;
        
        }

    
     
    }
}
