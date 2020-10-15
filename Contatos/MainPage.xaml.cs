using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contatos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            mylistView.ItemsSource = await App.Database.GetItemsAsync();

        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new PagePessoa()
                {
                    BindingContext = args.SelectedItem as Pessoa
                });

            }
        }

        private void OnClicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new PagePessoa()
            {
                BindingContext = new Pessoa()
            });
        }

    }
}
