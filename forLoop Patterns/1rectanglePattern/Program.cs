using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
        }

    }

}
