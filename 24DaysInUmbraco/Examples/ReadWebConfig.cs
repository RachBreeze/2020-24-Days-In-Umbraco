using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;

namespace _24DaysInUmbraco.Examples
{
    public class ReadWebConfig
    {
        public void ReaderSettings()
        {
            var VAT = decimal.Parse(ConfigurationManager.AppSettings["VAT"]);
            var emailInTestMode = bool.Parse(ConfigurationManager.AppSettings["emailInTestMode"]);
            var testEmailDomains = ConfigurationManager.AppSettings["testEmailDomains"];

        }
    }
}