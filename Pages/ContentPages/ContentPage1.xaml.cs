using Microsoft.Maui.Controls;

namespace ADVMOB1.Pages.ContentPages;

public partial class ContentPage1 : ContentPage
{
    
	public ContentPage1()
	{
		InitializeComponent();

        
	}

    
    private async void GoBack_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

    private async void GoToContentPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Pages.ContentPages.ContentPage2());
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        hiGIF.IsAnimationPlaying = true;
    }
}