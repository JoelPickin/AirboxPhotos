using AirboxPhotos.Models;
using AirboxPhotos.Views.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirboxPhotos.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoContentSelectorView : ContentView
    {
        public PhotoContentSelectorView()
        {
            InitializeComponent();
        }

        public static BindableProperty ItemListProperty = BindableProperty.Create(nameof(ItemList), typeof(ObservableCollection<Photo>), typeof(PhotoContentSelectorView), new ObservableCollection<Photo>(), BindingMode.TwoWay, propertyChanged: ItemListChanged);
        public ObservableCollection<Photo> ItemList
        {
            get => (ObservableCollection<Photo>)GetValue(ItemListProperty);
            set => SetValue(ItemListProperty, value);
        }

        private static void ItemListChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as PhotoContentSelectorView;
            control.SetContent();
        }

        protected void SetContent()
        {
            if (ItemList == null)
            {
                Content = new EmptyPlaceholderTemplate();
                return;
            }

            try
            {
                Content = SelectTemplate(ItemList);
            }
            catch
            {
                Content = new EmptyPlaceholderTemplate();
            }
        }

        public static View SelectTemplate(ObservableCollection<Photo> itemList)
        {
            var itemsCount = itemList.Count();

            View view = new EmptyPlaceholderTemplate();

            switch (itemsCount)
            {
                case 1:
                    view = new _1ItemTemplate();
                    break;
                case 2:
                    view = new _2ItemTemplate();
                    break;
                case 3:
                    view = new _3ItemTemplate();
                    break;
                case 4:
                    view = new _4ItemTemplate();
                    break;
                case 5:
                    view = new _5ItemTemplate();
                    break;
                case 6:
                    view = new _6ItemTemplate();
                    break;
                case 7:
                    view = new _7ItemTemplate();
                    break;
                case 8:
                    view = new _8ItemTemplate();
                    break;
                case 9:
                    view = new _9ItemTemplate();
                    break;
                default:
                    break;
            }

            return view;
        }
    }
}