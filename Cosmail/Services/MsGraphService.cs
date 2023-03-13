using Microsoft.Extensions.Configuration;

namespace Cosmail.Services;

/// <summary>
/// Service for Microsoft Graph settings.
/// </summary>
public class MsGraphService
{
	/// <summary>
	/// Constructor.
	/// </summary>
	/// <exception cref="Exception">Required settings not found.</exception>
	public MsGraphService()
	{
		// Load settings
		IConfiguration config = new ConfigurationBuilder()
			// appsettings.json is required
			.AddJsonFile("appsettings.json", optional: false)
			// appsettings.Development.json" is optional, values override appsettings.json
			.AddJsonFile($"appsettings.Development.json", optional: true)
			// User secrets are optional, values override both JSON files
			.AddUserSecrets<MauiApp>()
			.Build();

		var settings = config.GetRequiredSection("MsGraphSettings").Get<Settings>() ??
			   throw new Exception("Could not load app settings. See README for configuration instructions.");

		ClientId = settings.ClientId;
		TenantId = settings.TenantId;
	}

	/// <summary>
	/// Client id.
	/// </summary>
	public string ClientId { get; }

	/// <summary>
	/// Tenant id.
	/// </summary>
	public string TenantId { get; }
}

file class Settings
{
	public required string ClientId { get; set; }

	public required string TenantId { get; set; }
}