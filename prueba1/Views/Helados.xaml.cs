namespace prueba1.Views;

public partial class Helados : ContentPage
{
	public Helados()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
}