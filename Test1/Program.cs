using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that computes a sumatory where K=1 until K=10(power6) ....");            
            Console.WriteLine(process().ToString());
            Console.ReadLine();
        }

        public static double process()
        {
            var end = Math.Pow(10, 6);
            double result = 0;
            for (var k = 1; k < end; k++)
                result += 4 * (Math.Pow((-1), k + 1) / ((2 * k) - 1));
            return result;
        }
    }
}
