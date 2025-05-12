using System;

class Desafio2
{
    public static void Executar()
    {
        int numero = 21; // Pode ser substituído por entrada do usuário
        int a = 0, b = 1;

        while (b < numero)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        Console.WriteLine($"Resultado do Desafio 2:");
        if (b == numero || numero == 0)
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
    }
}
