namespace Utilities.RecipeRandomizer.Events
{
    public class PageViewedEvent
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