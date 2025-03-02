using OperacionesApp.ViewModels;

namespace OperacionesApp
{
    public partial class MainPage : TabbedPage
    {
        
        OperacionesViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new OperacionesViewModel();
            BindingContext = viewModel;
        }

        
    }

}
