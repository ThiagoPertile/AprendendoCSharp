using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");
        int idade;

        idade = 27;
        Console.WriteLine(idade);
        idade = idade - 1;
        Console.WriteLine(idade);
        idade = 5 * 2 - 6;
        Console.WriteLine(idade);
        idade = (5 - 2) * 3;
        Console.WriteLine(idade);


        Console.WriteLine("minha idade eh " + idade);
        Console.WriteLine("tecle Enter para fechar");
        Console.ReadLine();
    }
}