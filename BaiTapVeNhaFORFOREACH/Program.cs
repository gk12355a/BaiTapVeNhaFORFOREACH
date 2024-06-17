//Bai 3.1
using System;

namespace MultiplesOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 300; i >= 3; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
