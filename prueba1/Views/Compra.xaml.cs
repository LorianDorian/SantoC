namespace prueba1.Views;

public partial class Compra : ContentPage
{
	public Compra()
	{
		InitializeComponent();
	}
    string NumeroPedido = "###";
    private void OnCantidadChanged(object sender, ValueChangedEventArgs e)
    {
        lblCantidadSeleccionada.Text = $"Cantidad seleccionada: {e.NewValue}";
    }
    private void OnPagoSelectedIndexChanged(object sender, EventArgs e)
    {
        // Si el método de pago seleccionado es "Tarjeta", mostrar los campos adicionales
        if (pickerPago.SelectedIndex == 0) // 0 es el índice de "Tarjeta"
        {
            tarjetaFields.IsVisible = true;
        }
        else
        {
            tarjetaFields.IsVisible = false;
        }
    }

    // Manejar la confirmación de la compra

    private async void OnConfirmarCompraClicked(object sender, EventArgs e)
    {
        string nombreCliente = entryNombre.Text?.Trim();
        string metodoPago = pickerPago.SelectedItem?.ToString() ?? "No seleccionado";
        string metodoSucursal = pickerSucursal.SelectedItem?.ToString() ?? "No seleccionado";


        await DisplayAlert("¡Compra Confirmada! 🎉",
            $"Gracias, {nombreCliente} 🧡\n\n" +
            $"🛍️ Detalles del Pedido:\n" +
            $"- Cantidad: {cantidadStepper.Value}\n" +
            $"- Método de Pago: {metodoPago}\n" +
            $"- Método de Entrega: {metodoSucursal}\n" +
            $"- Número de Pedido: {NumeroPedido}",
            "Aceptar");

        ;

    }




}