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

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                Console.WriteLine("Se encontró en la posición " + i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("El número no está en el arreglo.");
        }
    }
}
