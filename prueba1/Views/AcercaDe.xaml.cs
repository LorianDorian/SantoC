using Microsoft.Maui.Controls;
using System;

namespace prueba1.Views
{
    public partial class AcercaDe : ContentPage
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private async void OnFacebookTapped(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.facebook.com/elsantochurromx");
        }

        private async void OnInstagramTapped(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://www.instagram.com/elsantochurromx/");
        }
        private async void OnSitiowebTapped(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync("https://g.co/kgs/gMyj9F2");
        }

    }
}
