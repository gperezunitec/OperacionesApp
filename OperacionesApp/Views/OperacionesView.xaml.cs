using OperacionesApp.ViewModels;

namespace OperacionesApp.Views;

public partial class OperacionesView : TabbedPage
{
	OperacionesViewModel viewModel;
	public OperacionesView()
	{
		
		InitializeComponent();
        viewModel = new OperacionesViewModel();
		BindingContext= viewModel;
    }
}