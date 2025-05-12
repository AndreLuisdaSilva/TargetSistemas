using System;

class Desafio5
{
    public static void Executar()
    {
        string original = "Desafio 5";
        char[] invertido = new char[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            invertido[i] = original[original.Length - 1 - i];
        }

        var resultado = new string(invertido);
        Console.WriteLine($"Resultado do Desafio 5:");
        Console.WriteLine($"String invertida: {resultado}"); // oifaseD
    }
}
