using System;

namespace test
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Enter Size :");
            var Size = Convert.ToInt32(Console.ReadLine());
            for (int row = Size; row >0; row--)
            {
                for (int col = row; col > 0; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }

}
