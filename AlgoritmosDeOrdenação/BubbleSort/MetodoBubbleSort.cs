using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgoritmosDeOrdenação.BubbleSort
{
    public static class MetodoBubbleSort
    {
        //static int[] vetor = new int[] { 13, 8, 5, 20, 10, 1, 5 };

        //public static void ImprimirVetor()
        //{
        //    Console.WriteLine("\n");
        //    for (int i = 0; i < vetor.Length; i++)
        //        Console.Write(vetor[i] + " ");
        //}

        

        public static void Rodar(int[] vetor)
        {
            //Imporante:  Vamos soltar uma variável no início do vetor,a medida que ele "andar", vai aprisonar o maior elemento e levará para ultima posição
            //A cada iteração se faz n-1 comparações.

            bool troca = true ; //Ele vai verificar se o vetor está ordenado, sem precisar pecorrer ele com as n-1 iteração

            Console.WriteLine($"Realizando BubbleSort em um vetor de: {vetor.Length} elementos");

            for (int rep = 0; rep < vetor.Length - 1 && troca; rep++) // Quantidade de vezes para ordena o vetor
            {
                troca = false;//Se tiver troca, você continua, para quando não tiver troca.

                for (int i = 0; i < vetor.Length - (rep+1); i++) //O vetor só chega a penultima posição e a comparação é reduzida conforme o vetor rep chega no final
                {
                    if (vetor[i] > vetor[i + 1]) 
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = temp;
                        troca = true;
                    }

                    //ImprimirVetor();
                }
            }


            //Gravar o vetor ordenada

            StreamWriter arquivoCriado;

            Console.Write("Informe o caminho do arquivo: ");
            string caminho2 = Console.ReadLine();

            arquivoCriado = File.CreateText(caminho2);

            for (int i = 0; i < vetor.Length; i++)
            {
                arquivoCriado.WriteLine(vetor[i]);
            }

            arquivoCriado.Close();



        }
    }
}
