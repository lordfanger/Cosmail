namespace Cosmail.Services;

public class MauiUiService
{
	private MainPage? _mainPage;

	public void RegisterMainPage(MainPage mainPage)
	{
		if (_mainPage != null && mainPage != _mainPage)
		{
			throw new InvalidOperationException("Main MAUI page was already registred.");
		}
		_mainPage = mainPage;
	}

	public async Task OnMainPage(Action<MainPage> action)
	{
		if (_mainPage == null)
		{
			throw new InvalidOperationException("Main MAUI page is not registred.");
		}
		await _mainPage.Dispatcher.DispatchAsync(() => action(_mainPage));
	}
}