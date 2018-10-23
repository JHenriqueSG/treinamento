using System;

namespace ComparacaoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1,        //primeiro numero a comparar
                numero2;        //segundo numero a comparar

            //le o primeiro numero inserido pelo usuario e o coverte
            Console.WriteLine("por favor insira o prieiro numero inteiro");
            numero1 = Int32.Parse(Console.ReadLine());

            //le o segundo numero do usuario e o converte
            Console.WriteLine("por favor insira o segundo numero inteiro");
            numero2 = Int32.Parse(Console.ReadLine());

            if(numero1 == numero2)
                Console.WriteLine(numero1 + " == " + numero2);  // declara "igual á"

            if(numero1 != numero2)
                Console.WriteLine(numero1 + " != " + numero2);  // declara "é diferente de"

            if(numero1 < numero2)
                Console.WriteLine(numero1 + " < " + numero2);  // declara "é menor que"

            if (numero1 > numero2)
                Console.WriteLine(numero1 +  " > " + numero2);  // declara "é maior que"

            if (numero1 <= numero2)
                Console.WriteLine(numero1 + " <= " + numero2);  // declara "é menor ou igual que"

            if (numero1 >= numero2)
                Console.WriteLine(numero1 + " >= " + numero2);  // declara "é maior ou igual a"



            Console.ReadKey(true);

        }//fi do metodo main


    }//fim da classe program


}//fim so namespace ComparacaoIf
