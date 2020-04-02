using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Module9_TP06.Entities;
using Xamarin_Module9_TP06.Services;

namespace Xamarin_Module9_TP06
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsPage : ContentView
{
        ObservableCollection<Tweet> Tweets = new ObservableCollection<Tweet>(new TwitterServiceImpl().getTweets());

        public TweetsPage()
    {
            //InitializeComponent();
            //this.list.ItemsSource = Tweets;
        }
}
}