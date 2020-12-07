using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _24DaysInUmbraco.Examples
{
    public class UmbracoAdventSettings : ConfigurationSection
    {
        public static UmbracoAdventSettings Settings { get; } = ConfigurationManager.GetSection("umbracoAdventSettings") as UmbracoAdventSettings;

        [ConfigurationProperty("vat",IsRequired = true)]
        public virtual decimal VAT => (decimal)this["vat"];

        [ConfigurationProperty("marketing")]
        public virtual MarketingElement MarketingSettings => (MarketingElement)this["marketing"];

        public class MarketingElement : ConfigurationElement
        {
            [ConfigurationProperty("emailInTestMode")]
            public virtual bool EmailInTestMode  => (bool)this["emailInTestMode"];

            [ConfigurationProperty("testEmailDomains")]
            public virtual string TestEmailDomains => (string)this["testEmailDomains"];
        }

    }
}