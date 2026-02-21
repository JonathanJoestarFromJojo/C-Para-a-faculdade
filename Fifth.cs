using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do salário semanal de 40 horas: ");
        string entradaSalario = Console.ReadLine();
        if (entradaSalario != null && double.TryParse(entradaSalario, NumberStyles.Any, CultureInfo.InvariantCulture, out double S))
        {
            double somaST = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite a quantidade de horas trabalhadas na semana: ");
                string entradaHoras = Console.ReadLine();

                if (entradaHoras != null && int.TryParse(entradaHoras, NumberStyles.Any, CultureInfo.InvariantCulture, out int h))
                {
                    if (h > 40)
                    {
                        double ST = S * 1.5; 
                        somaST += ST;
                    }
                    else
                    {
                        somaST += S; 
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida para horas. Semana ignorada.");
                }
            }

            Console.WriteLine("O valor total em 4 semanas é: " + somaST.ToString(CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Entrada inválida para salário.");
        }
    }
}