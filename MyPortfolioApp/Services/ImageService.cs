using System.Net.Http.Json;
using MyPortfolioApp.Models;

namespace MyPortfolioApp.Services;

public sealed class ImageService : IDisposable
{
    private readonly HttpClient _client;
    private readonly Task<List<Image>?> _getImagesTask;

    public ImageService(HttpClient client)
    {
        _client = client;
        _getImagesTask =
            _client.GetFromJsonAsync<List<Image>>(
                "sample-data/heroimages.json");
    }

    internal async Task<Image?> GetHeroAsync(Func<Image, bool> predicate)
    {
        var heroes = await _getImagesTask;
        return heroes?.FirstOrDefault(predicate);
    }

    public void Dispose() => _client.Dispose();
}
