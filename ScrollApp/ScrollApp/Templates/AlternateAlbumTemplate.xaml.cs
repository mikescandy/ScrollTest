using ScrollApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollApp.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlternateAlbumTemplate : Frame
    {
        public AlternateAlbumTemplate()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            if ((BindingContext is ArtistFlexLayoutViewModel song) && song.ImageUrl!=null)
            {
                //var uri = ((UriImageSource)UriImageSource.FromUri(new System.Uri(song.AlbumImageThumbnail)));
                //uri.CachingEnabled = true;
                //uri.CacheValidity = new System.TimeSpan(365, 0, 0, 0);
                var uri = ImageSource.FromUri(new System.Uri(song.ImageUrl));
                CachedImage.Source = uri;
            }

            base.OnBindingContextChanged();
        }
    }
}