
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
            await _dbService.SeedDataAsync();
            var menuItems = await _dbService.GetMenuItemsAsync();
            MenuCollectionView.ItemsSource = menuItems;
        }
    }
}
