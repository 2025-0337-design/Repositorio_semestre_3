using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de números que vas a poner: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa un número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        for (int i = 0; i < cantidad; i++)
        {
            if (numeros[i] > 0)
            {
                positivos++;
            }
            else if (numeros[i] < 0)
            {
                negativos++;
            }
            else
            {
                ceros++;
            }
        }

        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);
    }
}