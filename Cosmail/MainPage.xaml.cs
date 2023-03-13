using Cosmail.Services;

namespace Cosmail;

/// <summary>
/// Main MAUI page.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// MAUI Grid root content.
	/// </summary>
	public Grid Grid => grid;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="mauiUiService">Service for Blazor to MAUI interaction.</param>
	public MainPage(MauiUiService mauiUiService)
	{
		InitializeComponent();
		mauiUiService.RegisterMainPage(this);
	}
}
