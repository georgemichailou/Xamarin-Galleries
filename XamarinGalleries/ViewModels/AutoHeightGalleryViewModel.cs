using System.Collections.ObjectModel;

namespace XamarinGalleries.ViewModels
{
    public sealed class AutoHeightGalleryViewModel
    {
        private int _imageCount = 10;

        public AutoHeightGalleryViewModel()
        {
            Items = new ObservableCollection<string>
            {
                CreateSource(),
                CreateSource(true),
                CreateSource(),
                CreateSource(true),
                CreateSource(true),
                CreateSource(),
                CreateSource(),
                CreateSource(),
                CreateSource(),
                CreateSource(true),
                CreateSource(),
                CreateSource(true),
                CreateSource(),
                CreateSource(),
                CreateSource(),
                CreateSource(true),
                CreateSource(true),
                CreateSource(true),
                CreateSource(),
                CreateSource()
            };

        }

        public ObservableCollection<string> Items { get; }

        private string CreateSource(bool isHorizontalImage = false)
        {
            if(isHorizontalImage)
                return $"https://picsum.photos/1000/500?image={_imageCount++}";
            else
                return $"https://picsum.photos/1000/1000?image={_imageCount++}";
        }
    }
}