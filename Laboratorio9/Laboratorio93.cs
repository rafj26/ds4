using System;

class Laboratorio93
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el tercer lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (EsTrianguloValido(lado1, lado2, lado3))
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
        }
    }

    static bool EsTrianguloValido(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
