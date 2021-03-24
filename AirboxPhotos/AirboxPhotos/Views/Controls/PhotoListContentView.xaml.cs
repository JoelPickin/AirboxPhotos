using AirboxPhotos.Views.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirboxPhotos.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoListContentView : ContentView
    {
        public static readonly BindableProperty ItemListProperty = BindableProperty.Create(nameof(ItemList), typeof(IEnumerable<object>), typeof(PhotoListContentView), propertyChanged: ItemListChanged);

        public IEnumerable<object> ItemList
        {
            get => (IEnumerable<object>)GetValue(ItemListProperty);
            set => SetValue(ItemListProperty, value);
        }

        public static readonly BindableProperty TemplateProperty = BindableProperty.Create(nameof(Template), typeof(ContentView), typeof(PhotoListContentView), propertyChanged: TemplateChanged);

        private static void TemplateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var x = 0;
        }

        public ContentView Template
        {
            get => (ContentView)GetValue(TemplateProperty);
            set => SetValue(TemplateProperty, value);
        }

        private static void ItemListChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as PhotoListContentView;
            control.SelectContent();
        }

        protected void SelectContent()
        {
            if (ItemList == null)
            {
                Content = null;
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

        public static View SelectTemplate(IEnumerable<object> itemList)
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