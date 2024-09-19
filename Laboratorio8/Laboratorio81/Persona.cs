class Persona
{
    //Campo de cada objeto Persona que almacena su nombre

    public string Nombre;
    //Campo de cada objeto Persona que almacena su edad
    public int Edad;
    //campo de cada objeto Persona que almacena su NIF

    public string NIF;

    void Cumpleanos() //Incrementa en uno de edad del objeto Perona
    {
        Edad++;
    }

    //Constructor de Persona
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}

