using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _24DaysInUmbraco.Examples;

namespace _24DaysInUmbraco.Services
{
    public class EmailService
    {
        private readonly IUmbracoAdventSettingsWrapper _settingsWrapper;

        public EmailService(IUmbracoAdventSettingsWrapper settingsWrapper)
        {
            _settingsWrapper = settingsWrapper;
        }

        public bool CanSendEmail(string emailAddress)
        {
            if (!_settingsWrapper.Settings().MarketingSettings.EmailInTestMode)
            {
                return true;
            }

            var domain = emailAddress.Substring(emailAddress.IndexOf("@", StringComparison.Ordinal)).ToLower();
            return _settingsWrapper.Settings().MarketingSettings.TestEmailDomains.Contains(domain);
        }
    }
}