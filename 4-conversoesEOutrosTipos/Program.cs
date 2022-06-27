using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario); 

        int salarioInteiro = (int)salario;
        // O long eh um tipo de variavel de 64 bits
        long x = 2000000000000000000; ;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle ENTER para fechar o programa");
        Console.ReadLine();
    }
}