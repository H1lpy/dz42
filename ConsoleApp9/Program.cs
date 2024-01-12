using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());
            double p = 0;
            for (int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    p += Pow(i, 2) - 2 * j;
                }
            }
            Console.WriteLine(p);
        }
    }
}
