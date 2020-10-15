using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Contatos
{
    public partial class PagePessoa : ContentPage
    {
        public PagePessoa()
        {
            InitializeComponent();
        }

        private void onSalvePessoa(object sender, EventArgs args)
        {
            Pessoa p = BindingContext as Pessoa;
            App.Database.SaveItemAsync(p);
            Navigation.PopAsync();

        }
    }
}
