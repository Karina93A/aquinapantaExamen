namespace aquinapantaExamen.Vistas;

public partial class vRegistro : ContentPage
{
    public vRegistro(string cajaUsuario)
    {
        InitializeComponent();
        DisplayAlert("Bienvenido", cajaUsuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + cajaUsuario;

    }
    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        // Obt�n los datos ingresados en vRegistro.xaml
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("dd/MM/yyyy");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;


        // Crea una instancia de vResumen y p�sale los datos
        //vResumen resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual);
        vResumen resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial, pagoMensual);
        // Navega a la p�gina de resumen
        Navigation.PushAsync(resumenPage);
       



    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {


    }
}
