using Microsoft.Maui.Controls;
namespace ADVMOB1.Pages.ContentPages;

public partial class ContentPage2 : ContentPage
{
	public ContentPage2()
	{
		InitializeComponent();
	}

    private async void GoBack_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        aboutGIF.IsAnimationPlaying = true;
    }
}