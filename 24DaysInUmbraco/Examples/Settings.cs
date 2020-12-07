using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _24DaysInUmbraco.Examples
{
    public class Settings
    {
        public virtual decimal VAT => decimal.Parse(ConfigurationManager.AppSettings["VAT"]);

        public virtual bool EmailInTestMode => bool.Parse(ConfigurationManager.AppSettings["emailInTestMode"]);

        public virtual string TestEmailDomains => ConfigurationManager.AppSettings["testEmailDomains"];
    }
}