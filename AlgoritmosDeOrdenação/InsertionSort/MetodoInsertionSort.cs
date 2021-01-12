using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosDeOrdenação.InsertionSort
{
    public static class MetodoInsertionSort
    {
        static int[] vet = new int[] { 50, 69, 8, 37, 12, 12, 5 };

        static void ImprimiVetor()
        {
            Console.WriteLine();

            for (int i2 = 0; i2 < vet.Length; i2++)
                Console.Write(vet[i2] + " ");

            Console.WriteLine();
        }
        public static void Rodar()
        {
            for (int i = 1; i < vet.Length; i++) //Começa na posição 1, não começa na posição 0, por causa da comparação.
            {
                int temp = vet[i]; //Pega o elemento do vetor e armazena ele (Guarda o valor,da posição i).
                int j = i - 1; //Posição anterior ao vet[i]

                while ((j >= 0) && (vet[j] > temp))
                {
                    vet[j + 1] = vet[j]; // o valor maior e deslocado para p posiçãoda frente
                    j--;
                }

                vet[j + 1] = temp;

                Console.Write($"\n->Interação: {i}");
                ImprimiVetor();
            }

            //Outro modo de fazer o InsertionSort

            //for (int i = 1; i < vet.Length; i++)
            //{
            //    int temp, j;
            //    temp = vet[i];

            //    for (j = i - 1; j >= 0 && (vet[j] > temp); j--)
            //        vet[j + 1] = vet[j];


            //    vet[j + 1] = temp;

            //    ImprimiVetor();
            //}


        }
    }
}
