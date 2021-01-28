using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosDeOrdenação.QuickSort
{
    public static class MetodoQuickSort
    {
        static int[] vet = new int[] { 50, 69, 8, 37, 12, 12, 5 };
        static void ImprimiVetor()
        {
            Console.WriteLine();

            for (int i2 = 0; i2 < vet.Length; i2++)
                Console.Write(vet[i2] + " ");

            Console.WriteLine();
        }
        static int partion(int inicio, int fim)
        {
            int refe, up, down, temp;

            refe = vet[inicio];
            down = inicio;
            up = fim;

            while (down < up)
            {
                //Encontrando um número maior que o pivo (refe)
                while (vet[down] <= refe && down < fim)
                {
                    down++; //Encontrar um valor maior 
                }

                //Quero encontrar a partir do fim um valor menor que o meu de referencia.

                while (vet[up] > refe)
                {
                    up--;
                }

                if (down < up) //Eles não se cruzaram nos índices
                {
                    //troca
                    temp = vet[down];
                    vet[down] = vet[up];
                    vet[up] = temp;

                }
            }

            vet[inicio] = vet[up];
            vet[up] = refe;

            return up; //A posição de UP que denota onde está o pivô
        }


        static void quickSort(int inicio, int fim)
        {
            int pivo;

            if (inicio > fim)
            {
                return;
            }

            pivo = partion(inicio, fim);
            quickSort(inicio, pivo - 1);
            quickSort(pivo + 1, fim);
        }

        public static void Rodar()
        {
            quickSort(0, vet.Length - 1);
            ImprimiVetor();
        }
    }
}