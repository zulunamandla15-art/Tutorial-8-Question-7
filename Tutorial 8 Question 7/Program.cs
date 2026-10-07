using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8_Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Increasing Triangle
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
