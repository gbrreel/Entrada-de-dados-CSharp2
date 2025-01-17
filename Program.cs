using System;
using System.Globalization;

namespace dadosCSharp{};

class Program
{
    static void Main(String[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
        
        Console.WriteLine("Voce digitou:");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        
        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);

        Console.WriteLine("------- Exercicios --------");
        
        Console.WriteLine("Entre com o seu nome completo");
        string nomeUsuario = Console.ReadLine();
        
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Entre com o preço de um produto");
        double preco = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Seu ultimo nome, idade e altura");

        string[] infos = Console.ReadLine().Split(' ');
        string lastName = infos[1];
        int idadeNova = int.Parse(infos[2]);
        double alturaNova = double.Parse(infos[3], CultureInfo.InvariantCulture);

        Console.WriteLine(lastName);
        Console.WriteLine(idadeNova);
        Console.WriteLine(alturaNova.ToString("F2"), CultureInfo.InvariantCulture);
    }
    
}