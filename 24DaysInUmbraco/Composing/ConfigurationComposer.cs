using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _24DaysInUmbraco.Examples;
using Umbraco.Core.Composing;

namespace _24DaysInUmbraco.Composing
{
    // prepares the dependancy injection for the email serbive
    public class ConfigurationComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.RegisterFor<IUmbracoAdventSettingsWrapper, UmbracoAdventSettingsWrapper>();
            var testFileContents = UmbracoAdventSettings.Settings.VAT;
        }
    }
}