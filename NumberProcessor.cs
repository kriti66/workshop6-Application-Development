using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop6_Application_Development
{
    

public class NumberProcessor
    {
        // Method that accepts numbers + condition (Func delegate)
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

}

