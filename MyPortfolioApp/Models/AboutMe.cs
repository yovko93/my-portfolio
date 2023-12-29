namespace MyPortfolioApp.Models
{
    public class AboutMe
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public string Experience { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
    }
}
