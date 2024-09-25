using System;
using System.Collections.Generic;

class Laboratorio95
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.Write("Ingresa el valor mínimo: ");
        int minimo = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el valor máximo: ");
        int maximo = int.Parse(Console.ReadLine());

        Console.Write("Ingresa la cantidad de números: ");
        int cantidad = int.Parse(Console.ReadLine());

        if (cantidad > (maximo - minimo + 1))
        {
            Console.WriteLine("No se puede generar esa cantidad de números únicos entre el rango dado.");
        }
        else
        {
            int[] numerosUnicos = GenerarNumerosUnicos(aleatorios, minimo, maximo, cantidad);
            Console.WriteLine("Números no repetidos:");
            foreach (var num in numerosUnicos)
            {
                Console.WriteLine(num);
            }
        }
    }

    // Método para generar un arreglo de números únicos
    static int[] GenerarNumerosUnicos(Aleatorios aleatorios, int minimo, int maximo, int cantidad)
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        while (numerosUnicos.Count < cantidad)
        {
            numerosUnicos.Add(aleatorios.GenerarNumeroEntre(minimo, maximo));
        }
        return new List<int>(numerosUnicos).ToArray();
    }
}
