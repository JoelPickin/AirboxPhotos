using AirboxPhotos.Data;
using AirboxPhotos.ViewModels;
using AirboxPhotos.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace AirboxPhotos
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/PhotoListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PhotoListPage, PhotoListPageViewModel>();

            containerRegistry.Register<IPhotoRepository, PhotoRepostiory>();
            containerRegistry.RegisterForNavigation<PhotoViewerPage, PhotoViewerPageViewModel>();
        }
    }
}
