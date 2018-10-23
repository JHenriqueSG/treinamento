using System;

namespace InsertionSort
{
    class Program
    {
        static int InsertionSorting()
        {
            Console.Write("\nprograma para ordenação de elementos usando o Insertion Sorti");
            Console.Write("\n\nInsira o número de elementos: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nInsira [" + (i + 1).ToString() + "] elementos: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("int de entrada  : ");
            for (int k = 0; k < max; k++)
                Console.Write(numeros[k] + " ");
            Console.Write("\n");
            for (int i = 1; i < max; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (numeros[j - 1] > numeros[j])
                    {
                        int temp = numeros[j - 1];
                        numeros[j - 1] = numeros[j];
                        numeros[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
                Console.Write("interação " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numeros[k] + " ");
                Console.Write("\n");
                //Console.Write("/*** " + (i + 1).ToString() + " numbers from the begining of the array are input and they are sorted ***/\n");    
            }
            Console.Write("\n\nOs números em orden ascendente abaixo:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Elementos [" + (i + 1).ToString() + "] ordenados: ");
                Console.Write(numeros[i]);
                Console.Write("\n");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            InsertionSorting();
            Console.ReadLine();
        }
    }
}