namespace prueba1.Views;

public partial class Embotellados : ContentPage
{
	public Embotellados()
	{
		InitializeComponent();
	}
    private async void OnComprarClicked1(object sender, EventArgs e)
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