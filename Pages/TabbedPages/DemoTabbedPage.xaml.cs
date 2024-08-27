using Microsoft.Maui.Controls;
namespace ADVMOB1.Pages.TabbedPages;

public partial class DemoTabbedPage : TabbedPage
{
	public DemoTabbedPage()
	{
		InitializeComponent();
	}

    private void TabbedPage_Loaded(object sender, EventArgs e)
    {
		
		
		
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        hiGIF.IsAnimationPlaying = true;
    }

    private void ContentPage_Loaded_1(object sender, EventArgs e)
    {
        aboutGIF.IsAnimationPlaying = true;
    }

    private void ContentPage_Loaded_2(object sender, EventArgs e)
    {
        moreGIF.IsAnimationPlaying = true;
    }
}