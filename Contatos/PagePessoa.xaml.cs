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
        
        static String[] grupo = { "Familia", "Amigos", "Trabalho", "Comercial" };

        private void onSalvePessoa(object sender, EventArgs args)
        {
            Pessoa p = BindingContext as Pessoa;
            //App.Database.SaveItemAsync(p);
            //Navigation.PopAsync();

            if (String.IsNullOrEmpty(p.Nome))
            {
                DisplayAlert("Atenção", "O nome não pode ser vázio", "ok");
            }
            else
            {
                App.Database.SaveItemAsync(p);
                Navigation.PopAsync();

            }

        }
    }
}
