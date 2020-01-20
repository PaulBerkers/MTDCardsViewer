using MTDCardsViewer.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MTDCardsViewer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "cards")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Card> _cards = new List<Card>();

        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; NotifyPropertyChanged(); }
        }

        private Card _currentCard = new Card();

        public Card CurrentCard
        {
            get { return _currentCard; }
            set { _currentCard = value; NotifyPropertyChanged(); }
        }

        private string _imageUrl = "https://cdn.shopify.com/s/files/1/0030/6003/9729/products/il_fullxfull.1795105641_7sc9_1024x1024@2x.jpg?v-1556589325";

        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; NotifyPropertyChanged(); }
        }

        public MainPage()
        {
            this.InitializeComponent();
            GetCards();
        }

        private async void GetCards()
        {
            Cards = await MTGCardsAPIWrapper.GetCards();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            CurrentCard = e.ClickedItem as Card;
            if (CurrentCard.ImageUrl != null)
            {
                ImageUrl = CurrentCard.ImageUrl;
            }
            else
            {
                ImageUrl = "https://cdn.shopify.com/s/files/1/0030/6003/9729/products/il_fullxfull.1795105641_7sc9_1024x1024@2x.jpg?v-1556589325";
            }
        }
    }
}
