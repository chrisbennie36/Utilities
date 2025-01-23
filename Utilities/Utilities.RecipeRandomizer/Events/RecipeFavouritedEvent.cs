namespace Utilities.RecipeRandomizer.Events;

public class RecipeFavouritedEvent
{
    public int UserId { get; set; }
    public Uri RecipeUrl { get; set; }
    public string RecipeName { get; set; } = string.Empty;
}
