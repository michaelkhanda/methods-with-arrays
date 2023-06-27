using System;

namespace Methodswitharrays
{
    class Program
    {
        static int Addition(int[]x)
        {
            int total = 0;
            for(int i=0; i<5; i++)
            {
                total = total + x[i];
            }
            return total;
        }
        

        static void Main(string[] args)
        {
            int[] x = { 90, 89, 78, 45, 74 };
            int sum = Addition(x);
            Console.WriteLine("The sum is:" + " " + sum);
        }
    }
}
