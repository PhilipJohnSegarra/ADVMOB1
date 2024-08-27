using Microsoft.Maui.Controls;
namespace ADVMOB1.Pages.FlyoutPage;

public partial class DemoFlyoutPage : Microsoft.Maui.Controls.FlyoutPage
{
	public DemoFlyoutPage()
	{
		InitializeComponent();
	}

    private async void MainPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void ContentPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.ContentPages.ContentPage1());
    }

    private async void NavPage_Clicked(object sender, EventArgs e)
    {
        await (Detail as NavigationPage).PushAsync(new Pages.NavigationPages.NavigationPage1());
    }

    private async void TabbedPage_Clicked(object sender, EventArgs e)
    {
        await (Detail as NavigationPage).PushAsync(new Pages.TabbedPages.DemoTabbedPage());
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        flyGIF.IsAnimationPlaying = true;
    }
}