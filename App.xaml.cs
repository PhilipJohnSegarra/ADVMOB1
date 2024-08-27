namespace ADVMOB1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var firstPage = new NavigationPage(new MainPage());

            MainPage = firstPage;
        }
    }
}
