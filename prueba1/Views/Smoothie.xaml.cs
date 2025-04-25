namespace prueba1.Views;

public partial class Smoothie : ContentPage
{
	public Smoothie()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Compra());
    }
}