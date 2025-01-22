namespace MauiApp2_HACB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());

            navPage.BarBackgroundColor = Colors.Red;
            navPage.BarTextColor = Colors.White;

            MainPage = navPage;

            //MainPage = new FlyoutPage2();
        }
    }
}
