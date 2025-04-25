namespace prueba1.Views;

public partial class Personal : ContentPage
{
	public Personal()
	{
		InitializeComponent();   
    }

    private async void EditarNombre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDe());
    }
    private async void EditarCorreo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDe());
    }
    private async void EditarTelefono(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDe());
    }

    private async void EditarDireccion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDe());
    }
    private async void PedidosAnteriores(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDe());
    }
}