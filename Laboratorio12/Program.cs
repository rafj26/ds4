using Gtk;
using GTKToolboxComponents;
using System;

class Laboratorio121 : Window
{
    CustomEntry velocidadEntry, tiempoEntry;
    CustomLabel resultadoLabel;
    Fixed layout;

    public Laboratorio121() : base("Laboratorio 12-1: Calcular distancia")
    {
        SetDefaultSize(800, 600);
        SetPosition(WindowPosition.Center);

        layout = new Fixed();

        
        CustomLabel velocidadLabel = new CustomLabel("Velocidad (km/h):");
        velocidadEntry = new CustomEntry();
        layout.Put(velocidadLabel, 50, 50);
        layout.Put(velocidadEntry, 200, 50);

        
        CustomLabel tiempoLabel = new CustomLabel("Tiempo (horas):");
        tiempoEntry = new CustomEntry();
        layout.Put(tiempoLabel, 50, 100);
        layout.Put(tiempoEntry, 200, 100);

        
        CustomButton calcularButton = new CustomButton("Calcular", OnCalcularClicked);
        layout.Put(calcularButton, 50, 150);

        
        CustomButton limpiarButton = new CustomButton("Limpiar", OnLimpiarClicked);
        layout.Put(limpiarButton, 150, 150);

        
        CustomButton salirButton = new CustomButton("Salir", OnSalirClicked);
        layout.Put(salirButton, 250, 150);

        
        resultadoLabel = new CustomLabel("");
        layout.Put(resultadoLabel, 50, 200);

        Add(layout);
        ShowAll();
    }

    void OnCalcularClicked(object sender, EventArgs e)
    {
        try
        {
            double velocidad = Convert.ToDouble(velocidadEntry.Text);
            double tiempo = Convert.ToDouble(tiempoEntry.Text);
            double distancia = velocidad * tiempo;

            resultadoLabel.Text = $"Distancia recorrida: {distancia} km";
        }
        catch (FormatException)
        {
            resultadoLabel.Text = "Por favor, ingrese valores válidos.";
        }
    }


    void OnLimpiarClicked(object sender, EventArgs e)
    {
        velocidadEntry.Text = "";
        tiempoEntry.Text = "";
        resultadoLabel.Text = "";
    }

    void OnSalirClicked(object sender, EventArgs e)
    {
        Application.Quit();
    }

    public static void Main()
    {
        Application.Init();
        new Laboratorio121();
        Application.Run();
    }
}
