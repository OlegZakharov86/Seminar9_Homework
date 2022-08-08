// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

namespace Seminar9
{
    class Homework68
    {
        public static void Main()
        {
            Console.WriteLine("Введите первое значение M");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int Akkerman = AkkermanFunc(M, N);
            Console.WriteLine($"{Akkerman}");
        }
        static int AkkermanFunc(int M, int N)
        {
            if (M == 0)
            {
                return N + 1;
            }
            else
            {
                if (M != 0 && N == 0)
                {
                    return AkkermanFunc(M - 1, 1);
                }
                else
                {
                    if (M > 0 && N > 0) 
                    {
                        return AkkermanFunc(M - 1, AkkermanFunc(M, N - 1));
                    }
                }
                return AkkermanFunc(M, N);
            }
        }
    }
}  