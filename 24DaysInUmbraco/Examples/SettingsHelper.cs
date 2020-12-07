

using System.Configuration;

namespace _24DaysInUmbraco.Examples
{
    public static class SettingsHelper
    {
        public static decimal VAT()
        {
            return decimal.Parse(ConfigurationManager.AppSettings["VAT"]);
        }

        public static bool EmailInTestMode()
        {
            return bool.Parse(ConfigurationManager.AppSettings["emailInTestMode"]);
        }

        public static bool TestEmailDomains()
        {
            return bool.Parse(ConfigurationManager.AppSettings["TestEmailDomains"]);
        }
    }
}