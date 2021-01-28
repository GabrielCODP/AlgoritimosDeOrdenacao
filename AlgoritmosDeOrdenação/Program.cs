using System;
using AlgoritmosDeOrdenação.BubbleSort;
using AlgoritmosDeOrdenação.SelectionSort;
using AlgoritmosDeOrdenação.InsertionSort;


namespace AlgoritmosDeOrdenação
{
    class Program
    {
        static int[] vetor = new int[] { 13, 8, 5, 20, 10, 1, 5, 45 };

        static void Main(string[] args)
        {

            Console.WriteLine("::::::::::::::Algoritmo de Ordenação::::::::::::::");
            Console.Write("\n1-Buble Sort\n2-Selection Sort\n3-Insertion Sort\n4-Quick Sort\n\nEscolha uma ordenação:  ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                default:
                    break;

                case 1:
                    MetodoBubbleSort.Rodar(vetor);
                    break;
                case 2:
                    MetodoSelectionSort.Rodar(vetor);
                    break;
                case 3:
                    MetodoInsertionSort.Rodar(vetor);
                    break;

                case 4:
                    break;
            }





            //Teste

            ////Gravar o vetor ordenada

            //StreamWriter arquivoCriado;

            //Console.Write("Informe o caminho do arquivo: ");
            //string caminho2 = Console.ReadLine();

            //arquivoCriado = File.CreateText(caminho2);

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    arquivoCriado.WriteLine(vetor[i]);
            //}

            //arquivoCriado.Close();
        }
    }
}