﻿using System;
using ScrollApp.ViewModels;
using Xamarin.Forms;

namespace ScrollApp.Templates.Selectors
{
    public class ArtistDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SectionTitleTemplate { get; set; }
        public DataTemplate HeroTemplate { get; set; }
        public DataTemplate PopularSongTemplate { get; set; }
        public DataTemplate AlbumTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ArtistFlexLayoutViewModel vm)
            {
                switch (vm.FlexItemType)
                {
                    case FlexItemType.SectionTitle:
                        return SectionTitleTemplate;
                    case FlexItemType.HeroSection:
                        return HeroTemplate;
                    case FlexItemType.PopularSong:
                        return PopularSongTemplate;
                    case FlexItemType.Album:
                        return AlbumTemplate;

                }
            }
            throw new Exception();
        }
    }
}