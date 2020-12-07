using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24DaysInUmbraco.Examples
{
    public class TestExamples
    {
        public void GetValuesFromSettings()
        {
            var vat = new Settings().VAT;
            var emailInTestMode = new Settings().EmailInTestMode;
            var testEmailDomains = new Settings().TestEmailDomains;
        }
    }
}