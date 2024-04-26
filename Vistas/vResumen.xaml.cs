namespace aquinapantaExamen.Vistas;

public partial class vResumen : ContentPage
{
    public vResumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual)
    {
        InitializeComponent();

        // Configura los datos en la página de resumen

        lblApellido.Text = apellido;

    }
}