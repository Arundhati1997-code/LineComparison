using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class uc1
    {
        public static int Length1(int X1, int Y1, int X2, int Y2)
        {
            Console.WriteLine("welcome to line comparision");
             
            int length = ((int)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));

            Console.WriteLine("\n\n Length of line is" + length);
            Console.ReadLine();
            return length;
        }

        
    }
}

