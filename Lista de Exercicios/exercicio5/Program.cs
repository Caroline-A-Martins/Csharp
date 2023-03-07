using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        string res = (idade >= 18) ? ("Maior de idade") : ("Menor de idade");

        Console.WriteLine(res);
        Console.ReadKey();    
   
    }
}