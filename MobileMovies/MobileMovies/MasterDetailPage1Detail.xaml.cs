using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileMovies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }
        public ObservableCollection<Movieitem> Items { get; set; }

        public MasterDetailPage1Detail()
        {
            InitializeComponent();
        }

        public MasterDetailPage1Detail(int Id)
        {
            InitializeComponent();
            shit.Text = Id.ToString();
            //Items = new ObservableCollection<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3",
            //    "Item 4",
            //    "Item 5"
            //};

            Items = new ObservableCollection<Movieitem>
            {
              
                new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },new Movieitem
                {
                    Id = 1,
                    Name = "Name 1",
                    url = "url 1"
                },
            };

            MyListView.ItemsSource = Items;
        }



        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var items = e.Item as Movieitem;
            //await DisplayAlert("Item Tapped", "An item was tapped. "+items.Name, "OK");
            await Navigation.PushAsync(new MovieWatch());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
