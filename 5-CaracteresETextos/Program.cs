using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Execultando o projeto 5 - Caracteres e Textos");
        
        
        //no CHAR, diferentemente da STRING se usa aspas simples ('')
        char letra = 'a';
        Console.WriteLine(letra);
        letra = (char)65;
        Console.WriteLine(letra);
        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        letra = (char)(88 + 1);
        Console.WriteLine(letra);


        Console.WriteLine("Press ENTER para sair...");
        Console.ReadLine();
    }
}