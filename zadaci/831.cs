using System;
using System.Linq;

class AritmetickaSredina
{
    static void Main(string[] args)
    {
        double suma = 0;
        foreach(string broj in args)
        {
            suma += double.Parse(broj);
        }

        double prosek = suma / args.Length;

        // Ispis rezultata
        Console.WriteLine("Aritmetička sredina unetih brojeva je: {0}", prosek);
    }
}
