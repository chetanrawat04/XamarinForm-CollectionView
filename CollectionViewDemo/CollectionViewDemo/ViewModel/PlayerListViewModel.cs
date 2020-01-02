using CollectionViewDemo.Model;
using Plugin.SharedTransitions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewDemo.ViewModel
{
    public class PlayerListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Player> _PlayerList;
        private Player _SelectedPlayer;
        public decimal _total;
        public PlayerListViewModel()
        {
            LoadPlants();
        }

        public ObservableCollection<Player> PlayerList
        {
            get { return _PlayerList; }
            set
            {
                _PlayerList = value;
                OnPropertyChanged();
            }
        }

        public Player SelectedPlayer
        {
            get { return _SelectedPlayer; }
            set
            {
                _SelectedPlayer = value;
                OnPropertyChanged();
            }
        }


        private int _SelectedPlayerId;
        public int SelectedPlayerId
        {
            get { return _SelectedPlayerId; }
            set
            {
                _SelectedPlayerId = value;
                OnPropertyChanged();
            }
        }

        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

       // public ICommand SelectCommand => new Command(NavigateToPlantDetail);

        public ICommand SelectCommand
        {
            get
            {
                return new Command<CollectionView>((x) => NavigateToPlantDetail(x));
            }
        }

        private void LoadPlants()
        {
            PlayerList = new ObservableCollection<Player>(GetPlants());

        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void NavigateToPlantDetail(CollectionView v)
        {
            if(v.SelectedItem != null)
            {
                SelectedPlayerId = SelectedPlayer.Id;
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(App.Current.MainPage, SelectedPlayer.Name);
                await App.Current.MainPage.Navigation.PushAsync(new Views.PlayerDetails(SelectedPlayer));
                v.SelectedItem = null;
            }
        }
        public List<Player> GetPlants()
        {
            return new List<Player>
            {
                new Player { Id = 1, TotalPoint="887", Name = "Virat Kohli", Image = "ViratKohli.png", Age = 25, Description = "Virat Kohl is an Indian cricketer who currently captains the India national team. A right-handed top-order batsman, Kohli is regarded as one of the best batsmen in the world.[3] He plays for Royal Challengers Bangalore in the Indian Premier League (IPL), and has been the team's captain since 2013. Since October 2017, he has been the top-ranked ODI batsman in the world and is currently 1st in Test rankings with 928 points.[4][5]Among Indian batsmen, Kohli has the best ever Test rating (937 points), ODI rating (911 points) and T20I rating (897 points).Kohli captained India Under-19s to victory at the 2008 Under-19 World Cup in Malaysia. After a few months later, he made his ODI debut for India against Sri Lanka at the age of 19.Initially having played as a reserve batsman in the Indian team, he soon established himself as a regular in the ODI middle - order and was part of the squad that won the 2011 World Cup.He made his Test debut in 2011 and shrugged off the tag of ODI specialist by 2013 with Test hundreds in Australia and South Africa. Having reached the number one spot in the ICC rankings for ODI batsmen for the first time in 2013, Kohli also found success in the Twenty20 format, winning the Man of the Tournament twice at the ICC World Twenty20(in 2014 and 2016). " },
                new Player { Id = 2, TotalPoint="873", Name = "Rohit Sharma", Image = "RohitSharma.png", Age = 26, Description = "Rohit Sharma is one of the 15 players who have been named in the India squad to play the ICC Cricket World Cup 2019 in England and Wales. Rohit Sharma, who made his one-day international debut on 8-Dec-11, had played 206 ODI matches until the 2019 World Cup. In the 200 innings he batted in, he had scored a total of 8010 runs, having faced 9107 balls, at an average of 47.4 and a strike rate of 87.95. He was unbeaten in 31 of those innings. His highest score in an innings was 264. He had 22 centuries and 41 half-centuries to his name. In the bowling department, Rohit Sharma had bowled 593 balls and taken 8 wickets while conceding a total of 515 runs. He had an average of 64.38 and an economy rate of 5.21 His best ODI bowling performance was 2/27.\n Rohit Sharma is the vice-captain of the Indian national cricket team in limited-overs game. He plays for Mumbai in domestic cricket and captains Mumbai Indians in the Indian Premier League." },
                new Player { Id = 3, TotalPoint="834", Name = "Babar Azam", Image = "Babar.png", Age = 25, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 4, TotalPoint="820", Name = "Faf du Plessis", Image = "FafDu.png", Age =26, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 5, TotalPoint="817", Name = "Ross Taylor", Image = "Ross.png", Age = 30, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 6, TotalPoint="796", Name = "Kane Williamson", Image = "Kane.png", Age = 27, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 7, TotalPoint="794", Name = "David Warner", Image = "David.png", Age = 27, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 8, TotalPoint="787", Name = "Joe Root", Image = "Joe.png", Age = 27, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 9, TotalPoint="782", Name = "Shai Hope", Image = "ShaiHope.png", Age = 27, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." },
                new Player { Id = 10, TotalPoint="781", Name = "Quinton de Kock", Image = "Dekock.png", Age = 27, Description = "Lorem ipsum dolor sit amet consectetur adipiscing elit iaculis tristique inceptos egestas, dictum tincidunt lobortis a porttitor erat mus bibendum feugiat quis varius, nec eu risus sociis cras sollicitudin ullamcorper pellentesque vehicula aliquet. Eros convallis penatibus est donec habitant lacus elementum pellentesque, laoreet ligula suspendisse natoque faucibus nibh nascetur egestas euismod, semper mus facilisis aliquet sollicitudin hac varius. Sed tortor per rutrum commodo augue fermentum aliquet, proin feugiat turpis dis placerat congue taciti ultrices, facilisis tellus tincidunt venenatis et torquent." }

            };
        }

    }
}