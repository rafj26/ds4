using Gtk;
using GTKToolboxComponents;
using System;

class Laboratorio122 : Window
{
    CustomEntry nota1Entry, nota2Entry, nota3Entry;
    CustomLabel resultadoLabel;
    Fixed layout;

    public Laboratorio122() : base("Laboratorio 12-2: Calcular Promedio")
    {
        SetDefaultSize(800, 600);
        SetPosition(WindowPosition.Center);

        layout = new Fixed();

    
        CustomLabel nota1Label = new CustomLabel("Nota 1:");
        nota1Entry = new CustomEntry();
        layout.Put(nota1Label, 50, 50);
        layout.Put(nota1Entry, 200, 50);

        CustomLabel nota2Label = new CustomLabel("Nota 2:");
        nota2Entry = new CustomEntry();
        layout.Put(nota2Label, 50, 100);
        layout.Put(nota2Entry, 200, 100);

        CustomLabel nota3Label = new CustomLabel("Nota 3:");
        nota3Entry = new CustomEntry();
        layout.Put(nota3Label, 50, 150);
        layout.Put(nota3Entry, 200, 150);


        CustomButton calcularButton = new CustomButton("Calcular Promedio", OnCalcularClicked);
        layout.Put(calcularButton, 50, 200);

        
        resultadoLabel = new CustomLabel("");
        layout.Put(resultadoLabel, 50, 250);

        Add(layout);
        ShowAll();
    }

    void OnCalcularClicked(object sender, EventArgs e)
    {
        try
        {
            double nota1 = Convert.ToDouble(nota1Entry.Text);
            double nota2 = Convert.ToDouble(nota2Entry.Text);
            double nota3 = Convert.ToDouble(nota3Entry.Text);
            double promedio = (nota1 + nota2 + nota3) / 3;

            resultadoLabel.Text = $"Promedio: {promedio}";
        }
        catch (FormatException)
        {
            resultadoLabel.Text = "Por favor, ingrese notas válidas.";
        }
    }

    public static void Main()
    {
        Application.Init();
        new Laboratorio122();
        Application.Run();
    }
}
