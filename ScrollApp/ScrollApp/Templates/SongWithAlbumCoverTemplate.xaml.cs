using Pollux.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pollux.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongWithAlbumCoverTemplate : Grid
    {
        public SongWithAlbumCoverTemplate()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            CachedImage.Source = null;
            if (!(BindingContext is ArtistFlexLayoutViewModel item))
            {
                return;
            }

            var uri = ((UriImageSource)UriImageSource.FromUri(new System.Uri(item.ImageUrl)));
            uri.CachingEnabled = true;
            uri.CacheValidity = new System.TimeSpan(365, 0, 0, 0);
            CachedImage.Source = uri;

            base.OnBindingContextChanged();
        }
    }
}