using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string[] v = Console.ReadLine().Split(' ');
            string ultimonome = v[0];
            int idade2 = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome:");
            Console.WriteLine(frase);
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Console.WriteLine(quartos);
            Console.WriteLine("Preço de produto:");
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome, idade e altura na mesma linha:");
            Console.WriteLine(ultimonome);
            Console.WriteLine(idade2);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
