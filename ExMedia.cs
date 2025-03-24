using System; 
using System.Globalization;

class ExMedia {

    static void Main(string[] args) { 

        double A, B, media;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());

media = ((A * 4.0) + (B * 7.0)) /11;

Console.WriteLine("MEDIA = " + media.ToString("F5" , CultureInfo.InvariantCulture));

    }

}
