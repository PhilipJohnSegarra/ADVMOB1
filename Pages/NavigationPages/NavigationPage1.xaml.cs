using Microsoft.Maui.Controls;
namespace ADVMOB1.Pages.NavigationPages;

public partial class NavigationPage1 : ContentPage
{
	public NavigationPage1()
	{
		InitializeComponent();
	}

    private async void GoToNavPage2_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavigationPage2());
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        moreGIF.IsAnimationPlaying = true;
    }
}