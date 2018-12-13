using AsyncAwaitBestPractices;
using Xamarin.Forms;

namespace ScrollApp.Views
{
    public partial class FlexPage : ContentPage
    {
        private double _lastScroll;
        private bool _headerVisible;

        public FlexPage()
        {
            InitializeComponent();
            ScrollView.Scrolled += ParentScroll_Scrolled;
            Flex.ChildAdded += Flex_ChildAdded;
        }

        private void Flex_ChildAdded(object sender, ElementEventArgs e)
        {
            if (_image == null)
            {
                _herosection = (Grid)Flex.Children[0];
                _image = (Image)_herosection.Children[0];

                var scaleFactor = 1.15;

                _image.Scale = scaleFactor;
            }


        }

        protected override void OnDisappearing()
        {
            ScrollView.Scrolled -= ParentScroll_Scrolled;

            base.OnDisappearing();
        }

        private void ParentScroll_Scrolled(object sender, ScrolledEventArgs e)
        {
            if (_lastScroll == 0)
                _lastScroll = e.ScrollY;
            else
            {
                CalculateHeaderTranslation(e);
            }
        }

        private Image _image;
        private Grid _herosection;

        private void CalculateHeaderTranslation(ScrolledEventArgs e)
        {
            this.Content.FindByName("Scale");
            double translation = 0;

            if (_image == null)
            {
                _herosection = (Grid)Flex.Children[0];
                _image = (Image)_herosection.Children[0];
            }

            var _threshold = 180;


            if (e.ScrollY > _threshold && !_headerVisible)
            {
                Header.FadeTo(1).SafeFireAndForget();

                Fab.ScaleTo(0);
                _headerVisible = true;
            }
            else if (e.ScrollY < _threshold && _headerVisible)
            {

                Header.FadeTo(0).SafeFireAndForget();
                Fab.ScaleTo(1).SafeFireAndForget();
                _headerVisible = false;
            }
            System.Console.WriteLine(e.ScrollY);
            var scaleFactor = (2175 - e.ScrollY) / 1500;

            _image.Scale = scaleFactor;
            Fab.TranslationY = -e.ScrollY;
            _lastScroll = e.ScrollY;
        }
    }
}
