
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (row == 0 || col == 0 || row == num - 1 || col == num - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");

            }
        }

    }

}

