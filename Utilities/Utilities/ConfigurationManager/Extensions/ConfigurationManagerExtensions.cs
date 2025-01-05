namespace Utilities.ConfigurationManager.Extensions;

using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

public static class ConfigurationManagerExtensions
{
    public static string GetValue (this ConfigurationManager configurationManager, string key)
    {
        string? value = configurationManager[key];

        ArgumentNullException.ThrowIfNull(value);

        return value;
    }

    public static bool GetBoolValue(this ConfigurationManager configurationManager, string key)
    {
        string configValue = GetValue(configurationManager, key);

        bool boolConfigValue;

        if (!bool.TryParse(configValue, out boolConfigValue))
        {
            throw new ArgumentException($"Config value: {key} could not be parsed to a boolean");
        }

        return boolConfigValue;
    }

    public static int GetIntValue(this ConfigurationManager configurationManager, string key)
    {
        string configValue = GetValue(configurationManager, key);

        int intConfigValue;
        
        if (!int.TryParse(configValue, out intConfigValue))
        {
            throw new ArgumentException($"Config value: {key} could not be parsed to an int");
        }

        return intConfigValue;
    }
}
