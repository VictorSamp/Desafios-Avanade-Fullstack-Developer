using System;
using System.Globalization;
using System.Collections.Generic;

namespace validacao_de_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notasValidas = new List<double> { };
            double somaDasNotas = 0, media;

            while (notasValidas.Count != 2)
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0.0 || nota > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    notasValidas.Add(nota);
                }
            }

            foreach (double nota in notasValidas)
            {
                somaDasNotas += nota;
            }

            media = somaDasNotas / notasValidas.Count;
            Console.WriteLine("media = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
