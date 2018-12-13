using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrollApp.ViewModels
{
    public class FlexPageViewModel : ViewModelBase
    {
        public List<ArtistFlexLayoutViewModel> Items { get; set; }

        public FlexPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Items = new List<ArtistFlexLayoutViewModel>();

            Items.Add(new ArtistFlexLayoutViewModel
            {
                FlexItemType = FlexItemType.HeroSection,
                ImageUrl = "https://via.placeholder.com/1500",
                Text = "Elio e le Storie Tese"
            });

            Items.Add(new ArtistFlexLayoutViewModel
            {
                FlexItemType = FlexItemType.SectionTitle,
                Text = "Popular tracks"
            });

            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.PopularSong, Text = "Il Vitello Dai Piedi Di Balsa", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.PopularSong, Text = "Il Vitello Dai Piedi Di Balsa", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.PopularSong, Text = "Il Vitello Dai Piedi Di Balsa", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.PopularSong, Text = "Il Vitello Dai Piedi Di Balsa", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.PopularSong, Text = "Il Vitello Dai Piedi Di Balsa", ImageUrl = "https://via.placeholder.com/500" });
 
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });
            Items.Add(new ArtistFlexLayoutViewModel { FlexItemType = FlexItemType.Album, Text = "Cicciput", ImageUrl = "https://via.placeholder.com/500" });

        }
    }
}
