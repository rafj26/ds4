using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            //Ejemplo utilizando las variables de instancias de Clase
            cliente.FirstName = "Rolanndo";
            cliente.LastName = "Flores";
            cliente.Age = 25;
            cliente.Id = 8-948-2010;

            console.WriteLine(cliente.GetFullName());
        }
    }


    public class Cliente
    {
        //Declarando variables de instancias en clase.
        public int Id {get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Age {get; set}

        public string GetFullName()
        {
            //Utilizando variables de instancias dentro de metodos de la clase.
            return FirstName + " " + LastName;
        }
    }

}
