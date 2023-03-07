using System;

namespace exercicio1
{
    class Program
    {
    public static void Main(string[] args)
    {
        string nome, cidade;
        int idade;

        Console.Write("Seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Sua cidade: ");
        cidade = Console.ReadLine();
        Console.WriteLine();
        
        Console.Write(nome + ", " + idade + "anos, " + cidade);
        
        Console.ReadKey();
        }
    }
}