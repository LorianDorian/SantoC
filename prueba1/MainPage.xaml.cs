using prueba1.Views;

namespace prueba1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMenuClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AcercaDe());
        }
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }


        private async void OnLoginClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPrincipal());

        } 
        private async void OnLoginClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

    

    }
}

