using Verao.ViewsModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Verao.Views.Principal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
		public HomeView ()
		{
			InitializeComponent ();
            BindingContext = new HomeViewModel();
        }
	}
}