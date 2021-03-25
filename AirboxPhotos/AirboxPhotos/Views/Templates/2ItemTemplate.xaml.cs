using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirboxPhotos.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class _2ItemTemplate : ContentView
    {
        public _2ItemTemplate()
        {
            InitializeComponent();
        }

        public Aspect Aspect { get; set; } = Aspect.Fill;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > height)
            {
                Aspect = Aspect.AspectFill;
            }
        }
    }
}