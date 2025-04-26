namespace prueba1.Views;

public partial class Promociones : ContentPage
{
	public Promociones()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
}