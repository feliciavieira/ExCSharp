using System;
using System.Globalization;

namespace MediaNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            media = ((A * 2.0) + (B * 3.0) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1" , CultureInfo.InvariantCulture));
        }
    }
}
