namespace Utilities.RecipeRandomizer.Events
{
    public class RecipeRatedEvent
    {
        public int UserId { get; set; }
        public string RecipeName { get; set; } = string.Empty;
        public string RecipeUrl { get; set; } = string.Empty;
        public int RecipeRating { get; set; }
    }
}