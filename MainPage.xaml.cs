namespace ADVMOB1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToNavPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.NavigationPages.NavigationPage1());
        }

        private async void GoToTabbedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.TabbedPages.DemoTabbedPage());
        }

        private void GoToContPage1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pages.ContentPages.ContentPage1());
        }

        private async void GoToFlyoutPage_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new Pages.FlyoutPage.DemoFlyoutPage());
        }
    }

}
