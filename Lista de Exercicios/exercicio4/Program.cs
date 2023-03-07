using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        double a,b,c,res;

       Console.Write("Digite um número: ");
       a = double.Parse(Console.ReadLine());  

       Console.Write("Digite outro número: ");
       b = double.Parse(Console.ReadLine());  

       Console.Write("Digite outro número: ");
       c = double.Parse(Console.ReadLine()); 
       
       res = (a * a) * 5 - c / (b - a % 4);
       Console.Write(a+"² * 5 – " + c + "/ (" + b + " - " + a + " % 4) = " + res );
       Console.ReadKey();
        
       
    }
}