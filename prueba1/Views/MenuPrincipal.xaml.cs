using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace prueba1.Views
{
    public partial class MenuPrincipal : ContentPage
    {

        public class ImagenItem
        {
            public string Imagen { get; set; }
            public string PaginaDestino { get; set; }
        }

        public ObservableCollection<ImagenItem> Imagenes { get; set; } = new ObservableCollection<ImagenItem>
{
            new ImagenItem { Imagen = "carrusel1.jpg", PaginaDestino = "Frapes" },
            new ImagenItem { Imagen = "carrusel2.jpg", PaginaDestino = "Churros" },
            new ImagenItem { Imagen = "carrusel3.jpg", PaginaDestino = "Helados" },
            new ImagenItem { Imagen = "carrusel4.jpg", PaginaDestino = "Churros" }
};

        public MenuPrincipal()
        {
            InitializeComponent();
            BindingContext = this; // Asegúrate de que esté vinculando correctamente
        }

        private void OnMenuClicked(object sender, EventArgs e)
        {
            MenuLateral.IsVisible = true;
            Overlay.IsVisible = true;
        }
        private void OnOverlayTapped(object sender, EventArgs e)
        {
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        private void OnInicioClicked(object sender, EventArgs e)
        {
            DisplayAlert("Inicio", "Estás en la página de inicio.", "OK");
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        private async void OnAcercaDeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AcercaDe());
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }
        private async void OnSucursalesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sucursales());
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        private async void OnMicuentaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Personal());
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        private async void OnPromocionesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Promociones());
            MenuLateral.IsVisible = false;
        }
        private async void BtnChurros(object sender, EventArgs e)
        { await Navigation.PushAsync(new Churros()); }
        private async void BtnHelados(object sender, EventArgs e)
        { await Navigation.PushAsync(new Helados()); }
        private async void BtnFrappes(object sender, EventArgs e)
        { await Navigation.PushAsync(new Frapes()); }
        private async void BtnBebidas(object sender, EventArgs e)
        { await Navigation.PushAsync(new Bebidas()); }
        private async void BtnSmoothie(object sender, EventArgs e)
        { await Navigation.PushAsync(new Smoothie()); }
        private async void BtnCafe(object sender, EventArgs e)
        { await Navigation.PushAsync(new Cafe());}
        private async void btnCerrar(object sender, EventArgs e)
        { await Navigation.PushAsync(new MainPage()); }
        private async void OnImagenClicked(object sender, EventArgs e)
        {
            if (sender is ImageButton boton && boton.BindingContext is ImagenItem item)
            {
                switch (item.PaginaDestino)
                {
                    case "Churros":
                        await Navigation.PushAsync(new Churros());
                        break;
                    case "Helados":
                        await Navigation.PushAsync(new Helados());
                        break;
                    case "Frapes":
                        await Navigation.PushAsync(new Frapes());
                        break;
                    case "Smoothie":
                        await Navigation.PushAsync(new Smoothie());
                        break;
                    default:
                        await DisplayAlert("Aviso", "Página no disponible.", "OK");
                        break;
                }
            }
        }


    }
}

