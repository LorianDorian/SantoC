using System;
using Microsoft.Maui.Controls;

namespace prueba1.Views
{
    public partial class Helados : ContentPage
    {
        public Helados()
        {
            InitializeComponent();
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
                ConoFields.IsVisible = false;
                metodoPagoSeleccionado = "En vaso";
            }
            else if (boton == btnEfectivo)
            {
                tarjetaFields.IsVisible = false;
                ConoFields.IsVisible = true;
                metodoPagoSeleccionado = "En cono";
            }
        }
        private async void OnComprarBL5(object sender, EventArgs e)
        { await Navigation.PushAsync(new Compra()); }
    }
}
