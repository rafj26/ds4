using System;

class Laboratorio91
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        string formaPago;
        string numeroCuenta = "";

        do
        {
            Console.Write("Ingresa la forma de pago (efectivo/tarjeta): ");
            formaPago = Console.ReadLine().ToLower();
        } while (formaPago != "efectivo" && formaPago != "tarjeta");

        if (formaPago == "tarjeta")
        {
            do
            {
                Console.Write("Ingresa el número de cuenta (16 dígitos): ");
                numeroCuenta = Console.ReadLine();
            } while (numeroCuenta.Length != 16 || !long.TryParse(numeroCuenta, out _)); 
        }

        Console.WriteLine($"Producto con precio {precio} pagado con {formaPago}.");
        if (formaPago == "tarjeta")
        {
            Console.WriteLine($"Número de cuenta: {numeroCuenta}");
        }
    }
}
