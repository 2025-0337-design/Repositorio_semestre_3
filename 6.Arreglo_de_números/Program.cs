using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Ingresa un número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números ingresados:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}