using System;
using System.Reflection;
class Program
{
    
   static void Main()
    {
       Console.WriteLine("Digite os valores do primeiro ponto");
        double x1 = double.Parse(Console.ReadLine());
          double y1 = double.Parse(Console.ReadLine());


       Console.WriteLine("Digite os valores do segundo ponto");
        double x2 = double.Parse(Console.ReadLine());
          double y2 = double.Parse(Console.ReadLine());

       double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) );
        Console.WriteLine("Show " + d);
    
    }
}