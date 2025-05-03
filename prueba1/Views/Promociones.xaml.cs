namespace prueba1.Views;

public partial class Promociones : ContentPage
{
    public List<string> SaboresLeche { get; set; }
    public List<string> SaboresRudo { get; set; }
    public Promociones()
	{
		InitializeComponent();

        SaboresLeche = new List<string>
        { "Cajeta Coronado","Lechera","Chocolate Hersheys","Queso Crema","Nutella","Chocolate Blanco",
        "Piña Colada","Fresa","Zarzamora","Caramelo","Maple","Mango"};
        Sabores1.ItemsSource = SaboresLeche;
        SaboresRudo = new List<string>
        { "Cajeta Coronado","Lechera","Chocolate Hersheys","Queso Crema","Nutella","Chocolate Blanco",
        "Piña Colada","Fresa","Zarzamora","Caramelo","Maple","Mango"};
        Sabores.ItemsSource = SaboresRudo;
    }
    private async void OnComprarBL(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
    private void OnCantidadChanged(object sender, ValueChangedEventArgs e)
    {
        if (sender is Stepper stepper && stepper.Parent is Layout layout)
        {
            // Buscar el Label que está después del Stepper en el mismo layout
            foreach (var view in layout.Children)
            {
                if (view is Label label && label.Text.StartsWith("Cantidad seleccionada"))
                {
                    label.Text = $"Cantidad seleccionada: {e.NewValue}";
                    break;
                }
            }
        }
    }


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
    private void BotonDesplegar_Clicked1(object sender, EventArgs e)
    {
        // Cambia la visibilidad
        DetallesLayout1.IsVisible = !DetallesLayout1.IsVisible;

        // Opcional: cambia el texto del botón
        if (DetallesLayout1.IsVisible)
        {
            BotonDesplegar1.Text = "Ocultar Sabores:";
        }
        else
        {
            BotonDesplegar1.Text = "Mostrar Sabores:";
        }
    }
    private void OnSabor(object sender, EventArgs e)
    {
        // Acción al presionar el botón
        DisplayAlert("Churros", "¡Elegiste un sabor!", "OK");
    }
    private void OnSabor1(object sender, EventArgs e)
    {
        // Acción al presionar el botón
        DisplayAlert("Churros", "¡Elegiste un sabor!", "OK");
    }
    private void OnCheckBoxChanged(object sender, CheckedChangedEventArgs e)
    {
        // Si el CheckBox está marcado, mostramos el Picker
        SaboresPicker.IsVisible = e.Value;
    }
}