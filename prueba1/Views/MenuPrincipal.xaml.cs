using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
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
            DispararCarruselAutomatico();

        }

        // Navegación general sin switch, usando reflexión
        private async Task NavigateToPage(string pageName)
        {
            var fullTypeName = $"prueba1.Views.{pageName}";
            var pageType = Type.GetType(fullTypeName);

            if (pageType != null && Activator.CreateInstance(pageType) is Page page)
            {
                await Navigation.PushAsync(page);
                HideMenu();
            }
            else
            {
                await DisplayAlert("Aviso", $"Página \"{pageName}\" no disponible.", "OK");
            }
        }

        // Mostrar y ocultar menú lateral
        private void ShowMenu()
        {
            MenuLateral.IsVisible = true;
            Overlay.IsVisible = true;
        }

        private void HideMenu()
        {
            MenuLateral.IsVisible = false;
            Overlay.IsVisible = false;
        }

        private void OnMenuClicked(object sender, EventArgs e) => ShowMenu();

        private void OnOverlayTapped(object sender, EventArgs e) => HideMenu();

        // Botones del menú
        private async void OnInicioClicked(object sender, EventArgs e) => await NavigateToPage("MainPage");
        private async void OnAcercaDeClicked(object sender, EventArgs e) => await NavigateToPage("AcercaDe");
        private async void OnSucursalesClicked(object sender, EventArgs e) => await NavigateToPage("Sucursales");
        private async void OnMicuentaClicked(object sender, EventArgs e) => await NavigateToPage("Personal");
        private async void OnPromocionesClicked(object sender, EventArgs e) => await NavigateToPage("Promociones");
        private async void CarritoClicked(object sender, EventArgs e) => await NavigateToPage("Carrito");

        // Botones de categorías
        private async void BtnChurros(object sender, EventArgs e) => await NavigateToPage("Churros");
        private async void BtnHelados(object sender, EventArgs e) => await NavigateToPage("Helados");
        private async void BtnEmbotellados(object sender, EventArgs e) => await NavigateToPage("Embotellados");
        private async void BtnFrappes(object sender, EventArgs e) => await NavigateToPage("Frapes");
        private async void BtnBebidas(object sender, EventArgs e) => await NavigateToPage("Bebidas");
        private async void BtnSmoothie(object sender, EventArgs e) => await NavigateToPage("Smoothie");
        private async void BtnCafe(object sender, EventArgs e) => await NavigateToPage("Cafe");
        private async void btnCerrar(object sender, EventArgs e) => await NavigateToPage("MainPage");

        // Clic en imágenes del carrusel
        private async void OnImagenClicked(object sender, EventArgs e)
        {
            if (sender is ImageButton boton && boton.BindingContext is ImagenItem item)
            {
                await NavigateToPage(item.PaginaDestino);
            }
        }
        private async void DispararCarruselAutomatico()
        {
            while (true)
            {
                await Task.Delay(2000); // Espera 3 segundos entre cada imagen
                if (Imagenes.Count == 0) return;

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Avanza a la siguiente posición; vuelve al inicio si es necesario
                    MiCarrusel.Position = (MiCarrusel.Position + 1) % Imagenes.Count;
                });
            }
        }

    }
}
