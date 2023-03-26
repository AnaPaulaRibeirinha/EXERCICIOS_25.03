using System;

public class PesoIdeal
{
    public static void Main(string[] args)
    {
        Console.Write("Informe a altura (em metros): ");
        double h = double.Parse(Console.ReadLine());

        Console.Write("Informe o sexo (M para masculino ou F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72 * h) - 58;
            Console.WriteLine($"Peso ideal masculino de altura {h}m: {pesoIdeal:F1}kg.");
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * h) - 44.7;
            Console.WriteLine($"Peso ideal feminino de altura {h}m: {pesoIdeal:F1}kg.");
        }
        else
        {
            Console.WriteLine("Sexo invalido.");
        }

    }
}