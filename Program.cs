using System;
namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[2];
            Console.WriteLine("Введите 2 целых числа");
            for (int i = 0; i < 2; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = num[0]; i <= num[1]; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}