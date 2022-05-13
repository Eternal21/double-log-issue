using AspNetCore.Authentication.ApiKey;

namespace DoubleLogProject;

public class ApiKeyProvider : IApiKeyProvider
{
    private readonly ILogger<IApiKeyProvider> _logger;
    // private readonly IApiKeyRepository _apiKeyRepository;
	
    // public ApiKeyProvider(ILogger<IApiKeyProvider> logger, IApiKeyRepository apiKeyRepository)
    public ApiKeyProvider(ILogger<IApiKeyProvider> logger)
    {
        _logger = logger;
        // _apiKeyRepository = apiKeyRepository;
    }

    public async Task<IApiKey> ProvideAsync(string key)
    {
        try
        {
            return new ApiKey("testKey", "testOwner");
            // write your validation implementation here and return an instance of a valid ApiKey or return null for an invalid key.
            // return await _apiKeyRepository.GetApiKeyAsync(key);
            return null;
        }
        catch (System.Exception exception)
        {
            _logger.LogError(exception, exception.Message);
            throw;
        }
    }
}
