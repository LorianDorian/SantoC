namespace prueba1.Views;

public partial class Frapes : ContentPage
{
	public Frapes()
	{
		InitializeComponent();
	}

    private async void OnComprarClicked(object sender, EventArgs e)
    {await Navigation.PushAsync(new Compra());}
}