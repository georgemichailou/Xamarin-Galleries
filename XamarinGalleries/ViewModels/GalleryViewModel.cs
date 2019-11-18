using System.Collections.ObjectModel;

namespace XamarinGalleries.ViewModels
{
    public sealed class GalleryViewModel
    {
        private int _imageCount = 10;

        public GalleryViewModel()
        {
            Items = new ObservableCollection<string>();

            for (int i = 0; i < 20; i++)
            {
                Items.Add(CreateSource());
            }

        }

        public ObservableCollection<string> Items { get; }

        private string CreateSource()
        {
            return $"https://picsum.photos/1000/1000?image={_imageCount++}";
        }
    }
}