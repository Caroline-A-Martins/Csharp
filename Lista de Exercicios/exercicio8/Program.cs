using System;

public class Program
{
    public static void Main(string[] args)
    {
        int c=0;

        Console.WriteLine("Digite um valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro valor: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Valores lidos, {0} e {1}",a,b);
        
        c=a;
        a=b;
        b=c;
        
        Console.WriteLine("Valores invertidos, {0} e {1}",a,b);
        Console.ReadKey();
    }
}
