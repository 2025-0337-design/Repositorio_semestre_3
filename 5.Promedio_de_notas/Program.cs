using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántas notas vas a ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingresa la nota " + i + ": ");
            double nota = double.Parse(Console.ReadLine());

            suma += nota;
        }

        double promedio = suma / cantidad;

        Console.WriteLine("El promedio es: " + promedio);
    }
}