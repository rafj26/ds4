using System;

class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    // Método para generar un número aleatorio entre dos números
    public int GenerarNumeroEntre(int minimo, int maximo)
    {
        return random.Next(minimo, maximo + 1);
    }

    // Método para generar un arreglo de números aleatorios entre dos números
    public int[] GenerarArregloAleatorio(int minimo, int maximo, int cantidad)
    {
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            numeros[i] = GenerarNumeroEntre(minimo, maximo);
        }
        return numeros;
    }
}
