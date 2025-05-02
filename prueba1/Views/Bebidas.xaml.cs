namespace prueba1.Views;

public partial class Bebidas : ContentPage
{
    public List<string> SaboresLeche { get; set; }
    public Bebidas()
	{
		InitializeComponent();
        SaboresLeche = new List<string>
        { "Fresa","Zarzamora","Piña Colada","Mango","Frambuesa","Kiwi","Sandia","Lychee","Maracuya","Durazno","Taro","Coco",
        "Capuchino","Cajeta","Mazapán","Cookies","Chiclé","Java Chip","Te chai","Matcha","Mocha","Caramelo","Mocha Caramelo",
        "Chocolate mexicano","Chocolate blanco","Algodón de Azúcar"};
        Sabores.ItemsSource = SaboresLeche;
    }
    private async void OnComprarClicked(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
    private void BotonDesplegar_Clicked(object sender, EventArgs e)
    {
        // Cambia la visibilidad
        DetallesLayout.IsVisible = !DetallesLayout.IsVisible;

        // Opcional: cambia el texto del botón
        if (DetallesLayout.IsVisible)
        {
            BotonDesplegar.Text = "Ocultar Sabores:";
        }
        else
        {
            BotonDesplegar.Text = "Mostrar Sabores:";
        }
    }
    private async void OnComprarBebida(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }

    private void OnSabor(object sender, EventArgs e)
    {
        // Acción al presionar el botón
        DisplayAlert("Churros", "¡Elegiste un sabor!", "OK");
    }
}