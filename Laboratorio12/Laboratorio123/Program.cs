using Gtk;
using GTKToolboxComponents;
using System;

class Laboratorio123 : Window
{
    CustomEntry lado1Entry, lado2Entry, lado3Entry;
    CustomLabel semiperimetroLabel, areaLabel;
    Fixed layout;

    public Laboratorio123() : base("Laboratorio 12-3: Calcular Semiperímetro y Área")
    {
        SetDefaultSize(800, 600);
        SetPosition(WindowPosition.Center);

        layout = new Fixed();

        // Etiquetas y campos para los lados del triángulo
        CustomLabel lado1Label = new CustomLabel("Lado 1:");
        lado1Entry = new CustomEntry();
        layout.Put(lado1Label, 50, 50);
        layout.Put(lado1Entry, 200, 50);

        CustomLabel lado2Label = new CustomLabel("Lado 2:");
        lado2Entry = new CustomEntry();
        layout.Put(lado2Label, 50, 100);
        layout.Put(lado2Entry, 200, 100);

        CustomLabel lado3Label = new CustomLabel("Lado 3:");
        lado3Entry = new CustomEntry();
        layout.Put(lado3Label, 50, 150);
        layout.Put(lado3Entry, 200, 150);

        // Botón para calcular el semiperímetro y el área
        CustomButton calcularButton = new CustomButton("Calcular", OnCalcularClicked);
        layout.Put(calcularButton, 50, 200);

        // Etiquetas para mostrar el semiperímetro y el área
        semiperimetroLabel = new CustomLabel("");
        layout.Put(semiperimetroLabel, 50, 250);

        areaLabel = new CustomLabel("");
        layout.Put(areaLabel, 50, 300);

        Add(layout);
        ShowAll();
    }

    void OnCalcularClicked(object sender, EventArgs e)
    {
        try
        {
            double lado1 = Convert.ToDouble(lado1Entry.Text);
            double lado2 = Convert.ToDouble(lado2Entry.Text);
            double lado3 = Convert.ToDouble(lado3Entry.Text);

            // Cálculo del semiperímetro
            double semiperimetro = (lado1 + lado2 + lado3) / 2;
            semiperimetroLabel.Text = $"Semiperímetro: {semiperimetro}";

            // Cálculo del área usando la fórmula de Herón
            double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
            areaLabel.Text = $"Área: {area}";
        }
        catch (FormatException)
        {
            semiperimetroLabel.Text = "Por favor, ingrese valores válidos.";
        }
    }

    public static void Main()
    {
        Application.Init();
        new Laboratorio123();
        Application.Run();
    }
}
