using System;

class Desafio1
{
    public static void Executar()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine($"Resultado do Desafio 1: {SOMA}"); // Saída: 91
    }
}
