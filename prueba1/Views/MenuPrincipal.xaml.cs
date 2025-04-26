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
            BindingContext = this;
        }

        // Método generalizado para la navegación
        private async Task NavigateToPage(string pageName)
        {
            // Diccionario de páginas
            Page page = pageName switch
            {
                "Churros" => new Churros(),
                "Helados" => new Helados(),
                "Frapes" => new Frapes(),
                "Smoothie" => new Smoothie(),
                "Bebidas" => new Bebidas(),
                "Cafe" => new Cafe(),
                "Sucursales" => new Sucursales(),
                "AcercaDe" => new AcercaDe(),
                "MiCuenta" => new Personal(),
                "Promociones" => new Promociones(),
                "Inicio" => new MainPage(),
                _ => null
            };

            if (page != null)
            {
                // Navegación y ocultar menú
                await Navigation.PushAsync(page);
                HideMenu();
            }
            else
            {
                await DisplayAlert("Aviso", "Página no disponible.", "OK");
            }
        }

        // Método para ocultar el menú lateral y el overlay
        private void HideMenu()
        {
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        // Método para mostrar el menú lateral
        private void ShowMenu()
        {
            MenuLateral.IsVisible = true;
            Overlay.IsVisible = true;
        }

        // Eventos para mostrar y ocultar el menú
        private void OnMenuClicked(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void OnOverlayTapped(object sender, EventArgs e)
        {
            HideMenu();
        }

        // Métodos de los botones del menú
        private async void OnInicioClicked(object sender, EventArgs e)
        {
            await NavigateToPage("Inicio");
        }

        private async void OnAcercaDeClicked(object sender, EventArgs e)
        {
            await NavigateToPage("AcercaDe");
        }

        private async void OnSucursalesClicked(object sender, EventArgs e)
        {
            await NavigateToPage("Sucursales");
        }

        private async void OnMicuentaClicked(object sender, EventArgs e)
        {
            await NavigateToPage("MiCuenta");
        }

        private async void OnPromocionesClicked(object sender, EventArgs e)
        {
            await NavigateToPage("Promociones");
        }

        private async void BtnChurros(object sender, EventArgs e)
        {
            await NavigateToPage("Churros");
        }

        private async void BtnHelados(object sender, EventArgs e)
        {
            await NavigateToPage("Helados");
        }

        private async void BtnFrappes(object sender, EventArgs e)
        {
            await NavigateToPage("Frapes");
        }

        private async void BtnBebidas(object sender, EventArgs e)
        {
            await NavigateToPage("Bebidas");
        }

        private async void BtnSmoothie(object sender, EventArgs e)
        {
            await NavigateToPage("Smoothie");
        }

        private async void BtnCafe(object sender, EventArgs e)
        {
            await NavigateToPage("Cafe");
        }

        private async void btnCerrar(object sender, EventArgs e)
        {
            await NavigateToPage("Inicio");
        }

        // Método para manejar el clic en las imágenes del carrusel
        private async void OnImagenClicked(object sender, EventArgs e)
        {
            if (sender is ImageButton boton && boton.BindingContext is ImagenItem item)
            {
                await NavigateToPage(item.PaginaDestino);
            }
        }
    }
}
