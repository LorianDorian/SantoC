
namespace prueba1.Views;

public partial class Frapes : ContentPage
{

    public List<string> SaboresRudo { get; set; }
    public Frapes()
	{
		InitializeComponent();
        SaboresRudo = new List<string>
        { "Cajeta Coronado","Lechera","Chocolate Hersheys","Queso Crema","Nutella","Chocolate Blanco",
        "Piña Colada","Fresa","Zarzamora","Caramelo","Maple","Mango"};
        Sabores.ItemsSource = SaboresRudo;

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
        
    private void OnSabor(object sender, EventArgs e)
    {
        if (Sabores.SelectedIndex != -1)
        {

            string saborseleccionado = SaboresRudo[Sabores.SelectedIndex];
            Seleccion.Text = $"Sabor elegido:{saborseleccionado}";
        }
    }

}