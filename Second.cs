using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite três números inteiros.");
            int A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              int B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int S = (B + C) * (B + C);
                 int R = (A + B) * (A + B);
                     int D = (R + S) / 2;

        Console.WriteLine("O resultado é: " + D);
    }
}