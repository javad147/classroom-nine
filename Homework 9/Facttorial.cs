using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal  class Facttorial : CommonCalc
    {

        public int getFactorial(int a) 
        {
            int result = 1;
            for (int i = 0; i < a; i++)
            {
            
            result *= i;
            
            }

        return result;
        }
    }
}
