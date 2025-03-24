using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Http.Headers;

namespace MediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;
            double media;

            string[] vet;
            vet = Console.ReadLine().Split(" "); // Split da espaço na linha de entrada
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            string[] vet2;
            vet2 = Console.ReadLine().Split(" ");
            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            media = (double) (idade1 + idade2) / 2.0; 

            Console.WriteLine("A idade media de Maria e Joaquim é de " + media.ToString("F1", CultureInfo.InvariantCulture) + "anos.");

        }
    }
}
