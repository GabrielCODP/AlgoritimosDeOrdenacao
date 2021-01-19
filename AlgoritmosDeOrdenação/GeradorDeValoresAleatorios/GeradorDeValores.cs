using System;
using System.Collections.Generic;
using System.Text;
using System.IO; //Drogaria santa rita 

namespace AlgoritmosDeOrdenação.GeradorDeValoresAleatorios
{

    public static class GeradorDeValores
    {
        static int[] vetor;
        public static bool contem (int valor, int tamanho) //Não quero numeros repetidos.
        {
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == valor)
                    return true;
            }

            return false;
        }

       

        public static void Rodar()
        {
            Console.Write(". ");
            vetor = new int[int.Parse(Console.ReadLine())];
            //Console.Write($"Criei um vetor do tamanho: {vetor.Length}");

            //Gerar números aleatorios,sem números se repetir.

            int valor, pos;
            pos = 0;

            Random random = new Random();

            for (pos = 0; pos < vetor.Length; pos++)
            {
                do
                {
                   valor = (random.Next() * 100000) % 100000;

                } while (contem(valor,pos)); //Vou verificar se o valor tá no vetor, quando acha o valor, eu coloco ele no vetor.

                vetor[pos] = valor;
            }

            //Escolher o metodo...
            //MetodoBubbleSort.Rodar(vetor);
        }
    }
}
