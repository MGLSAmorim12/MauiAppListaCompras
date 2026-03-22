using MauiAppListaCompras.Helpers;

namespace MauiAppListaCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db 
        {
           get 
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                        "Banco_sqlite_comprasdb3");

                    _db = new SQLiteDatabaseHelper(".... db3");
                }
                
                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaProduto());
        }

        ///protected override Window CreateWindow(IActivationState? activationState)
       // {
           // return new Window(new AppShell());
       // }
    }
}