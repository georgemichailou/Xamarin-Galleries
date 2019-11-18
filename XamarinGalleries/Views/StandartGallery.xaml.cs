using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamarinGalleries.Views
{
    public partial class StandartGallery : ContentPage
    {
        public StandartGallery()
        {
            InitializeComponent();
        }

        void Images_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((CollectionView)sender).SelectedItem == null)
                return;

            string currentUrl = e.CurrentSelection.FirstOrDefault() as string;
            Navigation.PushModalAsync(new ImageView(currentUrl), true);
            ((CollectionView)sender).SelectedItem = null;

        }
    }
}
