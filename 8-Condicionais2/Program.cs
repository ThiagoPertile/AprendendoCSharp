using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Programa 7 - Condicionais");

        string nome = "Joao";
        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Bem-vindo " + nome);
        }
        else
        {
            Console.WriteLine("Acesso Negado");
        }


        Console.WriteLine("double tap ENTER To Exit");
        Console.ReadLine();
    }
}