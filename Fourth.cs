using System;
class Program
{
    
   static void Main()
    {
        double S = 0;
            for(int i = 1; i <= 50; i++)
                 {
                      S += ((2*i)-1)/(double)i;
                 }
             Console.WriteLine("O valor de S é: " + S);
    }
}