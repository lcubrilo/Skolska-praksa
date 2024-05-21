using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Niste uneli nijedan broj.");
            return;
        }

        // Inicijalizacija min i max sa prvom vrednošću
        double min = Double.Parse(args[0]);
        double max = Double.Parse(args[0]);

        // Iteracija kroz preostale argumente
        for (int i = 1; i < args.Length; i++)
        {
            double broj = Double.Parse(args[i]);
            if (broj < min)
            {
                min = broj;
            }
            if (broj > max)
            {
                max = broj;
            }
        }

        // Ispis rezultata
        Console.WriteLine("Najmanji broj: {0}", min);
        Console.WriteLine("Najveći broj: {0}", max);
    }
}
