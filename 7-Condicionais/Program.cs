using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Programa 7 - Condicionais");

        string nome = "Joao";
        string nomeAcompanhante = "Dona Marlene";
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Bem-vindo " + nome);
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Bem-vindo " + nome + " e " + nomeAcompanhante);
            }
            else

                Console.WriteLine("Acesso Negado");
        }


        Console.WriteLine("double tap ENTER To Exit");
        Console.ReadLine();
    }
}