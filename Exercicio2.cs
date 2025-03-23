using System;
using System.Globalization;

namespace Exercicio2 {
    class Exercicio {
        static void Main(string[] args) {
            
            int a, b, c;
            double resultado1;
            double resultado2;
            double resultado3;
            double resultado4;

            a = 5;
            b = 2;
            c = 9;

            resultado1 = (double) a / b;
            resultado2 = a + c / b;
            resultado3 = a * c;
            resultado4 = c - a;

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);

            Console.ReadLine();
        }
    }
}
