namespace Cosmail.Services;

/// <summary>
/// Service for Blazor to MAUI interaction.
/// </summary>
public class MauiUiService
{
	private MainPage? _mainPage;

	/// <summary>
	/// Register main page for further interaction from Blazor side.
	/// </summary>
	/// <param name="mainPage">Main page to register.</param>
	/// <exception cref="InvalidOperationException">Another page was already registered.</exception>
	public void RegisterMainPage(MainPage mainPage)
	{
		if (_mainPage != null && mainPage != _mainPage)
		{
			throw new InvalidOperationException("Main MAUI page was already registered.");
		}
		_mainPage = mainPage;
	}

	/// <summary>
	/// Execute action on MAIU main thread.
	/// </summary>
	/// <param name="action">Action to execute.</param>
	/// <returns>Awaitable task after executed action finish.</returns>
	/// <exception cref="InvalidOperationException">MAUI main page was not registered.</exception>
	public async Task OnMainPage(Action<MainPage> action)
	{
		if (_mainPage == null)
		{
			throw new InvalidOperationException("Main MAUI page is not registered.");
		}
		await _mainPage.Dispatcher.DispatchAsync(() => action(_mainPage));
	}
}