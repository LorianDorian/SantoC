namespace prueba1.Views;

public partial class Bebidas : ContentPage
{
	public Bebidas()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
}