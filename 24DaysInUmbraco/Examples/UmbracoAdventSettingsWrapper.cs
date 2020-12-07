using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24DaysInUmbraco.Examples
{
    public class UmbracoAdventSettingsWrapper : IUmbracoAdventSettingsWrapper
    {
        public UmbracoAdventSettings Settings()
        {
            return UmbracoAdventSettings.Settings;
        }
    }
}