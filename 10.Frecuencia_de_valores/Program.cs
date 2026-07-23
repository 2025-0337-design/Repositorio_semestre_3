using System;

class Program
{
    static void Main()
    {
        Console.Write("Cantidad de números: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];
        bool[] contado = new bool[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa un número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < cantidad; i++)
        {
            if (contado[i])
            {
                continue;
            }

            int veces = 1;

            for (int j = i + 1; j < cantidad; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    veces++;
                    contado[j] = true;
                }
            }
            if (veces == 1)
            {
                Console.WriteLine("El número " + numeros[i] + " se repite " + veces + " vez");
            }
            else
            {
                Console.WriteLine("El número " + numeros[i] + " se repite " + veces + " veces");
            }
        }
    }
}