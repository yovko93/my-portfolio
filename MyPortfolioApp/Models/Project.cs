namespace MyPortfolioApp.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string WebsiteImage { get; set; } = "Website Image";
        public List<string> SkillImages { get; set; } = new List<string>();
    }
}
