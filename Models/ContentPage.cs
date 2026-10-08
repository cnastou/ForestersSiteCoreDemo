namespace ForestersSiteCoreDemo.Models;

public class ContentPage
{
    public int Id { get; set; }

    public string PageKey { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Heading { get; set; } = string.Empty;

    public string HeroDescription { get; set; } = string.Empty;

    public string Body { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public bool Published { get; set; }
}