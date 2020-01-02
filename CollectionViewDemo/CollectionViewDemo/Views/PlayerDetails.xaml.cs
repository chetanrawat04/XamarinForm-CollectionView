
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayerDetails : ContentPage
	{
		public PlayerDetails (Model.Player a)
		{
			InitializeComponent ();
            this.BindingContext = a;
		}
	}
}