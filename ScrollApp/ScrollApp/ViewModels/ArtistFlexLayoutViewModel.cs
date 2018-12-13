using Prism.Mvvm;

namespace ScrollApp.ViewModels
{
    public enum FlexItemType
    {
        SectionTitle,
        HeroSection,
        PopularSong,
        Album
    }

    public class ArtistFlexLayoutViewModel: BindableBase
    {
        public FlexItemType FlexItemType { get; set; }
        public string ImageUrl { get; set; }
        public string Text { get; set; }
        public string Text2 { get; set; }
    }
}
