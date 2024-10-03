using Gtk;
using System;
using GTKToolboxComponents;  

class Program
{
    static void Main()
    {
        Application.Init();

        // ventana
        Window ventana = new Window("Ejemplo Click This");
        ventana.DeleteEvent += delegate { Application.Quit(); };
        ventana.SetDefaultSize(300, 200);

        //Contenedor virtual
        VBox vbox = new VBox(false, 5);

        // label
        CustomLabel lblHelloWorld = new CustomLabel("Label1");

        // boton
        CustomButton btnClickThis = new CustomButton("Click This", (s, e) =>
        {
            // convertir texto
            lblHelloWorld.Text = "Hello World!";
        });

        // componentes al virtual box
        vbox.PackStart(lblHelloWorld, false, false, 0);
        vbox.PackStart(btnClickThis, false, false, 0);

        // Agregar el contenedor a la ventana
        ventana.Add(vbox);
        ventana.ShowAll();

        Application.Run();
    }
}

