using Cosmail.Services;

namespace Cosmail;

public partial class App : Application
{
	public App(MauiUiService mauiUiService)
	{
		InitializeComponent();

		MainPage = new MainPage(mauiUiService);
	}
}
