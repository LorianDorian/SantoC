
namespace prueba1.Views
{
    public partial class Menu : ContentPage
    {
        private DatabaseService _dbService = new DatabaseService();
        public Menu()
        {
            InitializeComponent();
            LoadMenuItems();
        }

        private async void LoadMenuItems()
        {
            await _dbService.SyncWithApiAsync(); // ← download & store if online
            var menuItems = await _dbService.GetMenuItemsAsync(); // ← always read from local DB
            MenuCollectionView.ItemsSource = menuItems;
        }
    }


}
