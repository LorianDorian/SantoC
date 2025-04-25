namespace prueba1.Views;

public partial class Churros : ContentPage
{
	public Churros()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
}