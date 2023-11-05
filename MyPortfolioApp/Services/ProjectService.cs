using MyPortfolioApp.Models;
using System.Net.Http.Json;

namespace MyPortfolioApp.Services
{
    public sealed class ProjectService : IDisposable
    {
        private readonly HttpClient _client;
        private readonly Task<List<Project>?> _getProjectsTask;

        public ProjectService(HttpClient client)
        {
            _client = client;
            _getProjectsTask = _client.GetFromJsonAsync<List<Project>>("sample-data/projects.json");
        }

        internal async Task<List<Project>> GetProjectsAsync()
        {
            var projects = await _getProjectsTask;
            return projects.ToList();
        }

        public void Dispose() => _client.Dispose();
    }
}
