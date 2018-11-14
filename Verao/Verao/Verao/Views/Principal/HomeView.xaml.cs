using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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