using Microsoft.MobileBlazorBindings;
using Xamarin.Forms;
using AlemdarLabs.Spotify.Pages;
using AlemdarLabs.XF.BottomTabbedPage;
using AlemdarLabs.Spotify.Core;
using FFImageLoading.Forms;

namespace AlemdarLabs.Spotify
{
    public class App : Application
    {
        public static BottomTabbedPage BottomTabbedPageControl;

        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                })
                .Build();

            BottomTabbedPageControl = new BottomTabbedPage()
            {
                UnselectedTabColor = Color.White,
                BarTextColor = Color.White,
                BarBackgroundColor = AppResources.SoftBlackColor,
                SelectedTabColor = Color.White
            };

            MainPage = BottomTabbedPageControl;

            host.AddComponent<SpotifyApp>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
