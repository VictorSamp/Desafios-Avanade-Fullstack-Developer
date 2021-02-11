using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int quadrado = (int)Math.Pow(i, 2.0);
                int cubo = (int)Math.Pow(i, 3.0);
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}