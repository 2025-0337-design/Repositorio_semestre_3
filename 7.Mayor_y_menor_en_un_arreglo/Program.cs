using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            bool esValido = false;
            while (!esValido)
            {
                Console.Write("Ingresa un número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros[i] = numero;
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: Debes ingresar un número entero válido.");
                }
            }
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }
}
