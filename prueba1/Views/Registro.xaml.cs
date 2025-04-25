namespace prueba1.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void OnLoginClicked4(object sender, EventArgs e)
    {
        if (!chkAceptar.IsChecked)
        {
            DisplayAlert("Aviso", "Debes aceptar los términos y condiciones", "OK");
            return;
        }

        string usuario = txtUsuario.Text;
        string correo = txtCorreo.Text;
        string contraseña = txtContraseña.Text;
        string telefono = txtTelefono.Text;
        string domicilio = txtDomicilio.Text;

        // Aquí podrías agregar lógica para guardar el usuario o hacer validaciones

        DisplayAlert("Registro exitoso", $"¡Bienvenido, {usuario}!", "OK");
    }

}