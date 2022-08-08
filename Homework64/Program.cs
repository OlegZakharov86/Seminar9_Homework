// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

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
            int sum = SumOfElements(M,N);
            Console.WriteLine($"{sum}");
        }
        static int SumOfElements(int M, int N)
        {
            int sum = 0;
            for (int i = M; i <= N; i++)
            {
                sum +=i;
            }
            return sum; 
        }
    }
}