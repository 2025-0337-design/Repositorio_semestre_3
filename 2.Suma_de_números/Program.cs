using System;

class Program
{
    static void Main()
    {
        int numero = 1;
        int suma = 0;

        while (numero <= 100)
        {
            suma += numero;
            numero++;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}
