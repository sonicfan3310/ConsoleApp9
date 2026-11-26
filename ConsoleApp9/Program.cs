using System;

namespace ConsoleApp
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.Write("До: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            fixed (int* p = numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    *(p + i) += 10;
                }
            }

            Console.WriteLine();

            Console.Write("После: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int x = 50;

            int* p2 = &x;
            int** pp = &p2;

            Console.WriteLine("Адрес x: 0x" + ((ulong)&x).ToString("X"));
            Console.WriteLine("Адрес p: 0x" + ((ulong)&p2).ToString("X"));

            Console.WriteLine("Значение x до: " + x);

            **pp = 999;

            Console.WriteLine("Значение x после изменения через **pp: " + x);

            Console.ReadKey();
        }
    }
}
