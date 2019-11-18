using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinGalleries
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetBackButtonTitle(this, "Galleries");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.TwoColumnsGallery(), true);
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.ThreeColumnsGallery(), true);
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.AutoHeightGallery(), true);
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.StandartGallery(), true);
        }

        void Handle_Clicked_4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.VerticalGallery(), true);
        }

        void Handle_Clicked_5(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.HorizontalGallery(), true);
        }
    }
}
