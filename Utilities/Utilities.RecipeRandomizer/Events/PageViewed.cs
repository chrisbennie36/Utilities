namespace Utilities.RecipeRandomizer.Events
{
    public class PageViewed
    {
        public PageType PageType { get; set; }
    }

    public enum PageType
    {
        RecipePreferencesOverview,
        MeatBasedPreferences,
        PescatarianBasedPreferences,
        VegetarianBasedPreferences
    }
}