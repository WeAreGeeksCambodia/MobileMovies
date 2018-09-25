using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileMovies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieWatch : ContentPage
    {
        public MovieWatch()
        {
            InitializeComponent();
            VideoPlayer.FullScreenStatusChanged += VideoPlayer_FullScreenStatusChanged;
        }

        private void VideoPlayer_FullScreenStatusChanged(object sender, bool e)
        {
            NavigationPage.SetHasNavigationBar(this, !e);
        }

        public MovieWatch(Movieitem item)
        {
            InitializeComponent();
            VideoPlayer.FullScreenStatusChanged += VideoPlayer_FullScreenStatusChanged;
            //Browser.Source = new HtmlWebViewSource().Html = @"<html><body>
            //<h1>Xamarin.Forms</h1>
            //<p>Welcome to WebView.</p>
            //</body></html>";

            //@"<iframe src=""https://www.youtube.com/embed/4Emkqztwf6A?list=RDPNSsaoEG2H8"" frameborder=""0"" allow=""autoplay; encrypted-media"" allowfullscreen></iframe>";
        }
    }
}