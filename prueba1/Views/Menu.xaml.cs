using System.Collections.ObjectModel;

namespace prueba1.Views
{
    public partial class Menu : ContentPage
    {
        public class ImagenItem
        {
            public string Imagen { get; set; }
        }

        public ObservableCollection<ImagenItem> Imagenes { get; set; } = new ObservableCollection<ImagenItem>
        {
            new ImagenItem { Imagen = "menu1.jpg" },
            new ImagenItem { Imagen = "menu2.jpg" }
        };

        public Menu()
        {
            InitializeComponent();
            BindingContext = this; 
        }

        private async void OnImagenClicked(object sender, EventArgs e)
        {
                
        }
    }
}
