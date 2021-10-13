using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Activity01
{
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            /* image temporária no cache */
            var imagem2 = new Image();
            imagem2.Aspect = Aspect.AspectFit;

            imagem2.Source = new UriImageSource
            {
                Uri = new System.Uri("https://polivocidade.files.wordpress.com/2011/04/cruz-vazia.png?w=584"),
                CachingEnabled = false,
                CacheValidity = new System.TimeSpan(5, 0, 0),
            };
            ActivityIndicator activityIndicator = new ActivityIndicator
            {
                Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default),
                IsRunning = true,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            StackLayout stk = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            stk.Children.Add(activityIndicator);
            stk.Children.Add(imagem2);

            Button bt1 = new Button
            {
                BackgroundColor = Color.Green,
                Padding = 10,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White,
                Text = "Próxima",
                CornerRadius = 6
            };
            bt1.Clicked += Bt1_Clicked;
            stk.Children.Add(bt1);
            Content = stk;
        }

        private void Bt1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
