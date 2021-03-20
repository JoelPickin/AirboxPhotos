using AirboxPhotos.ViewModels;
using AirboxPhotos.Views.Templates;
using System;
using Xamarin.Forms;

namespace AirboxPhotos.Views
{
    public partial class PhotoListPage : ContentPage
    {
        public PhotoListPage()
        {
            InitializeComponent();

            Content = SetContentView();
        }

        private View SetContentView()
        {
            var viewModel = (BindingContext as PhotoListPageViewModel);

            View contentView = new EmptyPlaceholderTemplate();

            if (viewModel != null)
            {
                var photosCount = viewModel.Photos.Count;

                switch (photosCount)
                {
                    case 1:
                        contentView = new _1ItemTemplate();
                        break;
                    case 2:
                        contentView = new _2ItemTemplate();
                        break;
                    case 3:
                        contentView = new _3ItemTemplate();
                        break;
                    case 4:
                        contentView = new _4ItemTemplate();
                        break;
                    case 5:
                        contentView = new _5ItemTemplate();
                        break;
                    case 6:
                        contentView = new _6ItemTemplate();
                        break;
                    case 7:
                        contentView = new _7ItemTemplate();
                        break;
                    case 8:
                        contentView = new _8ItemTemplate();
                        break;
                    case 9:
                        contentView = new _9ItemTemplate();
                        break;
                    default:
                        break;
                }
            }

            return contentView;
        }
    }
}
