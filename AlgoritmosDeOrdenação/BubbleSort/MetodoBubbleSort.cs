using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgoritmosDeOrdenação.BubbleSort
{
    public static class MetodoBubbleSort
    {
        public static void ImprimirVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
                Console.Write(vetor[i] + " ");
        }

        public static void Rodar(int[] vetor)
        {
            //Imporante:  Vamos soltar uma variável no início do vetor,a medida que ele "andar", vai aprisonar o maior elemento e levará para ultima posição
            //A cada iteração se faz n-1 comparações.

            Console.WriteLine($"Realizando BubbleSort em um vetor de: {vetor.Length} elementos");

            for (int rep = 0; rep < vetor.Length - 1; rep++) // Quantidade de vezes para ordena o vetor
            {
                for (int i = 0; i < vetor.Length - (rep + 1); i++) //O vetor só chega a penultima posição e a comparação é reduzida conforme o vetor rep chega no final
                {
                    if (vetor[i] > vetor[i + 1]) //O elemento atual é maior que seu próximo,se sim troca.
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = temp;
                    }
                }

                Console.WriteLine($"\n\n->Final da {rep + 1}° Interação: ");
                ImprimirVetor(vetor);
            }



            // Observação, essa iteração reduz o número de comparações e de iterações

            //bool troca = true; //Ele vai verificar se o vetor está ordenado, sem precisar pecorrer ele com as n-1 iteração.

            //for (int rep = 0; rep < vetor.Length - 1 && troca; rep++) 
            //{
            //    troca = false;//Se tiver troca, você continua, para quando não tiver troca.

            //    for (int i = 0; i < vetor.Length - (rep + 1); i++) 
            //    {
            //        if (vetor[i] > vetor[i + 1]) 
            //        {
            //            int temp = vetor[i];
            //            vetor[i] = vetor[i + 1];
            //            vetor[i + 1] = temp;
            //            troca = true;
            //        }
            //    }

            //    Console.WriteLine($"\n\n->{rep}° Interação: ");
            //    ImprimirVetor(vetor);
            //}
        }
    }
}