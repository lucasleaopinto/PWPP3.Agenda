using System;

using Xamarin.Forms;

namespace Application
{
    public class ContentPessoa : ContentPage
    {
        public ContentPessoa()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

