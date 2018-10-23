using System;

namespace ExercitandoALogica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para somar dois números e multiplicar o resultado pelo primeiro número.*/

            Console.WriteLine("somando dois inteiros");
            int a, b, c;
            Console.WriteLine("\ndigite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\ndigite o segundo numero: ");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("\no resultado é: "+ c);
            Console.WriteLine("\nmultiplicando o resultado pelo primeiro numero");
            Console.WriteLine("\n"+ c * a);

            Console.ReadKey(true);

            //2 – Elabore um algoritmo que calcule a idade média de 5 alunos.

            int media = 0;
            int idade1 = 0;
            int idade2 = 0;
            int idade3 = 0;
            int idade4 = 0;
            int idade5 = 0;

            Console.WriteLine("infomre a idade do primeiro aluno: ");
            idade1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("infomre a idade do segundo aluno: ");
            idade2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("infomre a idade do terceiro aluno: ");
            idade3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("infomre a idade do quarto aluno: ");
            idade4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("infomre a idade do quinto aluno: ");
            idade5 = Convert.ToInt32(Console.ReadLine());

            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine("a idade media dos alunos é {0}, ", media);

            Console.ReadKey(true);

            //2 – Crie um algoritmo que verifique se um número informado é par ou impar.

            int x, y;






        }


    }
}
