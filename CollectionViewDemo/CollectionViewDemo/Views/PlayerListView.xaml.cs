
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlayerListView : ContentPage
	{
		public PlayerListView ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            if(toolbar.ClassId == "squares")
            {
                toolbar.IconImageSource = "list.png";
                toolbar.ClassId = "list";
                var itemGrid = new GridItemsLayout(ItemsLayoutOrientation.Vertical);
                itemGrid.Span = 2;
                playerList.ItemsLayout = itemGrid;
            }
            else
            {
                toolbar.IconImageSource = "squares.png";
                toolbar.ClassId = "squares";

                var itemList = new LinearItemsLayout(ItemsLayoutOrientation.Vertical);
                
                playerList.ItemsLayout = itemList;
            }
        }
    }
}