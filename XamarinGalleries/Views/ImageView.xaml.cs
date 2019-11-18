using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamarinGalleries.Views
{
    public partial class ImageView : ContentPage
    {
        public ImageView(string imageUrl)
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            TapGestureRecognizer tapEvent = new TapGestureRecognizer();
            tapEvent.Tapped+= (sender, e) => {
                Navigation.PopModalAsync(true);
            };

            CancelImg.GestureRecognizers.Add(tapEvent);

            ZoomImage.Source = imageUrl;
        }
    }
}
