using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activity01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            imagem1.Source = new UriImageSource
            {
                Uri = new Uri("https://i.ytimg.com/vi/7UB7AlgaLy0/maxresdefault.jpg"),
                CachingEnabled = false
            };
            imagem1.Aspect = Aspect.AspectFit;
        }
    }
}