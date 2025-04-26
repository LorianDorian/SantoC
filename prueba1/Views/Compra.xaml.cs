namespace prueba1.Views
{
    public partial class Compra : ContentPage
    {
        public Compra()
        {
            InitializeComponent();
        }

        string NumeroPedido = "###";

        // Actualizar la cantidad seleccionada
        private void OnCantidadChanged(object sender, ValueChangedEventArgs e)
        {
            lblCantidadSeleccionada.Text = $"Cantidad seleccionada: {e.NewValue}";
        }

        // Mostrar u ocultar los campos de tarjeta dependiendo del método de pago

        private ImageButton botonSeleccionado;
        private string metodoPagoSeleccionado;

        private void OnMetodoPagoClicked(object sender, EventArgs e)
        {
            var boton = sender as ImageButton;

            // Reiniciar todos los estilos
            btnTarjeta.Opacity = 0.5;
            btnEfectivo.Opacity = 0.5;

            // Botón seleccionado visualmente
            boton.Opacity = 1;

            // Guardar botón seleccionado y método
            botonSeleccionado = boton;

            if (boton == btnTarjeta)
            {
                tarjetaFields.IsVisible = true;
                metodoPagoSeleccionado = "Tarjeta Bancaria";
            }
            else if (boton == btnEfectivo)
            {
                tarjetaFields.IsVisible = false;
                metodoPagoSeleccionado = "En sucursal";
            }
        }

        private async void OnConfirmarCompraClicked(object sender, EventArgs e)
        {
            string nombreCliente = entryNombre.Text?.Trim();
            string metodoSucursal = pickerSucursal.SelectedItem?.ToString() ?? "No seleccionado";

            if (string.IsNullOrEmpty(metodoPagoSeleccionado))
            {
                metodoPagoSeleccionado = "No seleccionado";
            }

            await DisplayAlert("¡Compra Confirmada! 🎉",
                $"Gracias, {nombreCliente} 🧡\n\n" +
                $"🛍️ Detalles del Pedido:\n" +
                $"- Cantidad: {cantidadStepper.Value}\n" +
                $"- Método de Pago: {metodoPagoSeleccionado}\n" +
                $"- Método de Entrega: {metodoSucursal}\n" +
                $"- Número de Pedido: {NumeroPedido}",
                "Aceptar");
        }

    }
}
