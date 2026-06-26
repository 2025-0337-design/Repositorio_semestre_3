using System;

class Program
{
    static void Main()
    {

        double contaminacion;
        int ciclo = 0;

        Console.Write("Ingrese los PPM iniciales: ");
        contaminacion = double.Parse(Console.ReadLine());

        while (contaminacion > 10 && ciclo < 15)
        {
            ciclo++;

            if (ciclo <= 4)
            {
                // primeros 4  12.5%
                contaminacion -= contaminacion * 0.125;
            }
            else
            {
                // ciclo 5 el filtro reduce 6%
                contaminacion -= contaminacion * 0.06;
            }

            Console.WriteLine("Ciclo: " + ciclo);
            Console.WriteLine("Nivel de contaminacion: " + contaminacion);
        }

        Console.WriteLine();
        Console.WriteLine("Resultado Final");


        if (contaminacion <= 10)
        {
            Console.WriteLine("Agua potable");
            Console.WriteLine("PPM final: " + contaminacion);
            Console.WriteLine("Ciclos utilizados: " + ciclo);
            Console.WriteLine("La contaminacion se redujo a un nivel que puedes beber.");
        }
        else
        {
            Console.WriteLine("Filtro saturado");
            Console.WriteLine("PPM final: " + contaminacion);
            Console.WriteLine("Ciclos utilizados: " + ciclo);
            Console.WriteLine("El agua no alcanzo el nivel de potabilidad no es segura para beber.");
        }

    }
}