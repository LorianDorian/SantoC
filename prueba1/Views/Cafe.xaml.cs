namespace prueba1.Views;

public partial class Cafe : ContentPage
{
	public Cafe()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
}