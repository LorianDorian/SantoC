namespace prueba1.Views;

public partial class Churros : ContentPage
{

    public List<string> SaboresRudo { get; set; }
    public Churros()
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
    private void OnCheckBoxChanged(object sender, CheckedChangedEventArgs e)
    {
        // Si el CheckBox está marcado, mostramos el Picker
        SaboresPicker.IsVisible = e.Value;
    }
    private void OnCheckBoxChanged1(object sender, CheckedChangedEventArgs e)
    {
        // Si el CheckBox está marcado, mostramos el Picker
        SaboresPicker2.IsVisible = e.Value;
    }
    private void OnSabor(object sender, EventArgs e)
    {
        // Acción al presionar el botón
        DisplayAlert("Churros", "¡Elegiste un sabor!", "OK");
    }
    private async void OnComprarDark(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
    private async void OnComprarRudo(object sender, EventArgs e)
    { await Navigation.PushAsync(new Compra()); }
    private async void OnComprarTecnico(object sender, EventArgs e)
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
}