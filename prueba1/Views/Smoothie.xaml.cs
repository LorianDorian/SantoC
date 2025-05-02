namespace prueba1.Views;

public partial class Smoothie : ContentPage
{
    public List<string> SaboresLeche { get; set; }
    public Smoothie()
	{
		InitializeComponent();
        SaboresLeche = new List<string>
        { "Sandia","Lychee","Frambuesa","Kiwi","Maracuyá","Fresa","Zarzamora","Mango",
        "Piña Colada","Tamarindo","Durazno"};
        Sabores.ItemsSource = SaboresLeche;
    }
    private async void OnComprarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Compra());
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
    private async void OnComprarBebida(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }

    private void OnSabor(object sender, EventArgs e)
    {
        // Acción al presionar el botón
        DisplayAlert("Churros", "¡Elegiste un sabor!", "OK");
    }
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
}