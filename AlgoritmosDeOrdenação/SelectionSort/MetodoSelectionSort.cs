using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosDeOrdenação.SelectionSort
{
    public static class MetodoSelectionSort
    {

        //Dado um conjunto de dados, pego o menor elemento e coloco na ultima posição...

        static int[] vet = new int[] { 50, 69, 8, 37, 12, 12, 5 };

        static void ImprimiVetor()
        {
            Console.WriteLine();

            for (int i2 = 0; i2 < vet.Length; i2++)
                Console.Write(vet[i2] + " ");

            Console.WriteLine();
        }

        static void swap(int menorElementoInicio, int i)
        {
            int temp = vet[menorElementoInicio]; //Armazena o menor elemento temporiamente.
            vet[menorElementoInicio] = vet[i];  //a posição onde estava o menor elemento,recebe o elemento inicial da posição do vetor
            vet[i] = temp;

            ImprimiVetor();
        }

        public static void Rodar()
        {

            for (int i = 0; i < vet.Length - 1; i++)  //Vai até a penultima posição,a quantidade de iteração é (n-1)...
            {
                int menorElementoInicio = i;
               

                for (int i2 = i + 1; i2 < vet.Length; i2++)
                {
                    if (vet[menorElementoInicio] > vet[i2])
                        menorElementoInicio = i2; //Vai armazenar o menor elemento encontrado...
                }

                Console.Write($"\n->Interação: {i}");
                swap(menorElementoInicio, i);
            }



            //Outro modo

            //int it, menorInicial, i;

            //for (it = 0; it < vet.Length - 1; it++)
            //{
            //    menorInicial = it;

            //    for (i = it + 1; i < vet.Length; i++)
            //    {
            //        if (vet[menorInicial] > vet[i])
            //            menorInicial = i;
            //    }

            //    if (vet[it] > vet[menorInicial]) 
            //    {
            //        int temp = vet[menorInicial];
            //        vet[menorInicial] = vet[it];
            //        vet[it] = temp;
            //    }

            //    ImprimiVetor();

            //}


        }
    }
}
