using CollectionViewDemo.Model;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace CollectionViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }

        private async void PlayerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            foreach (var item in e.CurrentSelection)
            {
                var tappedItemData = item as Player;
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, tappedItemData.Name);
                SharedTransitionNavigationPage.SetTransitionDuration(this, 350);
                // SharedTransitionNavigationPage.SetTransitionSelectedGroup(App.Current.MainPage, SelectedPlant.Name);
                await Navigation.PushAsync(new Views.PlayerDetails(tappedItemData));
            }
           
           
        }
    }
}
