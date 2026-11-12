namespace AlvionStudios.Models;
public class PortfolioProject
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string CoverImagePath { get; set; } = string.Empty;
    public string CoverImageAlt { get; set; } = string.Empty;
}