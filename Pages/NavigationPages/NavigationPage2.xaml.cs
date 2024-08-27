using Microsoft.Maui.Controls;
namespace ADVMOB1.Pages.NavigationPages;

public partial class NavigationPage2 : ContentPage
{
	public NavigationPage2()
	{
		InitializeComponent();
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		aboutGIF.IsAnimationPlaying = true;
    }
}