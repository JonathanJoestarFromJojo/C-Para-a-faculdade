using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do produto: ");
        string entradaPreco = Console.ReadLine();
        Console.WriteLine("Digite a venda média mensal: ");
        string entradaMedia = Console.ReadLine();

        if (entradaPreco != null && entradaMedia != null &&
            double.TryParse(entradaPreco, NumberStyles.Any, CultureInfo.InvariantCulture, out double price) &&
            int.TryParse(entradaMedia, NumberStyles.Any, CultureInfo.InvariantCulture, out int mediamensal))
        {
            double pricenovo = price;

            if (price < 30.00 && mediamensal < 500)
            {
                pricenovo = price * 1.1; 
            }
            else if (price >= 30.00 && mediamensal >= 500)
            {
                pricenovo = price / 1.2; 
            }
            else
            {
                Console.WriteLine("Valores não condizem com as condições de mudança de preços.");
            }

            Console.WriteLine("Preço final do produto: " + pricenovo.ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite números válidos.");
        }
    }
}