using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua sexualidade (M/F) Masculino ou Feminino, e sua altura: ");
        string sexo = Console.ReadLine()!;

        if (double.TryParse(Console.ReadLine(), out double h))
        {
            if (sexo == "M" || sexo == "m")
            {
                double P = (72 * h) - 58;
                    Console.WriteLine("Peso ideal: " + P);
            }
            else if (sexo == "F" || sexo == "f")
            {
                double P = (62.1 * h) - 44.7;
                     Console.WriteLine("Peso ideal: " + P);
            }
            else
            {
                     Console.WriteLine("Digite somente M ou F para masculino ou feminino");
            }
        }
        else
        {
            Console.WriteLine("Altura inválida, digite um número válido.");
        }
    }
}