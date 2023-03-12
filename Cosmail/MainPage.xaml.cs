using Cosmail.Services;

namespace Cosmail;

public partial class MainPage : ContentPage
{
	public Grid Grid => grid;

	public MainPage(MauiUiService mauiUiService)
	{
		InitializeComponent();
		mauiUiService.RegisterMainPage(this);
	}
}
