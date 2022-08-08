// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

namespace Seminar9
{
    class Homework66
    {
        public static void Main()
        {
            Console.WriteLine("Введите первое значение M");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            string result = NewString(M, N);
            Console.WriteLine($"{result}");
        }
        static string NewString(int M, int N)
        {
            string result = String.Empty;
            for (int i = M; i <= N; i++)
            {
                result += $"{i} ";
            }
            return result;
        }
    }
}