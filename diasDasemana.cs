using System;
using System.Globalization;
class teste_ec
{
    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        string dia;

        if (x == 1) {
            dia = "Domingo";
        }
        else if (x ==2) {
            dia = "Segunda-Feira";
        }
        else if (x == 3) {
            dia = "Terça-Feira";
        }
        else if (x == 4) {
            dia = "Quarta-Feira";
        }
        else if (x == 5) {
            dia = "Quinta-Feira";
        }
        else if (x == 6) {
            dia = "Sexta=Feira";
        }
        else if (x == 7) {
            dia = "Sabado";
        }
        else {
            dia = "Invalido";
        }
        Console.WriteLine("Dia da semana: " + dia);
        Console.ReadLine(); 
    }
}
