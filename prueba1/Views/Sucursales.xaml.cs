namespace prueba1.Views;

public partial class Sucursales : ContentPage
{
	public Sucursales()
	{
		InitializeComponent();
	}

    private void BotonDesplegar_Clicked(object sender, EventArgs e)
    {
        // Cambia la visibilidad
        DetallesLayout.IsVisible = !DetallesLayout.IsVisible;

        // Opcional: cambia el texto del botón
        if (DetallesLayout.IsVisible)
        {
            BotonDesplegar.Text = "Ocultar Detalles";
        }
        else
        {
            BotonDesplegar.Text = "Mostrar Detalles";
        }
    }

    private void BotonDesplegar_Clicked2(object sender, EventArgs e)
    {
        // Cambia la visibilidad
        DetallesLayout2.IsVisible = !DetallesLayout2.IsVisible;

        // Opcional: cambia el texto del botón
        if (DetallesLayout2.IsVisible)
        {
            BotonDesplegar2.Text = "Ocultar Detalles";
        }
        else
        {
            BotonDesplegar2.Text = "Mostrar Detalles";
        }
    }
}