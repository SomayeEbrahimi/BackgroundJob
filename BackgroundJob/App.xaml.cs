using BackgroundJob.Service;
using Matcha.BackgroundService;
using Xamarin.Forms;

namespace BackgroundJob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainView());
        }

        protected override void OnStart()
        {
            StartBackgroundService();
        }

        protected override void OnSleep()
        {
            StartBackgroundService();
        }

        protected override void OnResume()
        {
            StartBackgroundService();
        }

        private static void StartBackgroundService()
        {
            BackgroundAggregatorService.Add(() => new WriterService());

            BackgroundAggregatorService.StartBackgroundService();
        }
    }
}
