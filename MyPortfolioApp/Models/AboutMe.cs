namespace MyPortfolioApp.Models
{
    public class AboutMe
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
    }
}
