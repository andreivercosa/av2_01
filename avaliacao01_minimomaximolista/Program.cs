using System;
using System.Collections.Generic;

namespace avaliacao01_minimomaximolista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listanumeros = new List<int>();

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Informe os numeros d lista: ");
                listanumeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            listanumeros.Sort();//ordenar lista do maior para o menor

            Console.WriteLine("Minimo: {0}", listanumeros[0]);
            Console.WriteLine("Maximo: {0}", listanumeros[listanumeros.Count- 1]);//Count conta
        }
    }
}
