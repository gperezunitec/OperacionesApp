using OperacionesApp.Views;

namespace OperacionesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OperacionesView();
        }
    }
}
