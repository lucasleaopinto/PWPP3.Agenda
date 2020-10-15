using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contatos
{
    public partial class App : Application
    {
        private static PessoaItemDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static PessoaItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PessoaItemDatabase(DependencyService.Get < IFileHelper>()
                        .GetLocalFilePath("PessoaSQLite.db3"))  ;
                }

                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
