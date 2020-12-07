using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24DaysInUmbraco.Examples;
using _24DaysInUmbraco.Services;
using Moq;
using NUnit.Framework;

namespace _24DaysInUmbraco.Tests.Services
{
    public class WhenSendingEmails
    {
        [Test]
        public void IfTheSiteIsNotInTestModeEmailsCanBeSent()
        {
            var settings = new Mock<IUmbracoAdventSettingsWrapper>();
            settings.Setup(x => x.Settings().MarketingSettings.EmailInTestMode).Returns(false);
            var emailService = new EmailService(settings.Object);
            Assert.AreEqual(emailService.CanSendEmail("anyeamil@this.com"), true);
        }
        [Test]
        public void IfTheSiteInTestModeEmailAndTheEmailIsNotInTheTestDomainItCanNotBeSent()
        {
            var settings = new Mock<IUmbracoAdventSettingsWrapper>();
            settings.Setup(x => x.Settings().MarketingSettings.EmailInTestMode).Returns(true);
            settings.Setup(x => x.Settings().MarketingSettings.TestEmailDomains).Returns("@myemail.com");
            var emailService = new EmailService(settings.Object);
            Assert.AreEqual(emailService.CanSendEmail("anyeamil@this.com"), false);
        }

        [Test]
        public void IfTheSiteInTestModeEmailAndTheEmailIsInTheTestDomainItCanBeSent()
        {
            var settings = new Mock<IUmbracoAdventSettingsWrapper>();
            settings.Setup(x => x.Settings().MarketingSettings.EmailInTestMode).Returns(true);
            settings.Setup(x => x.Settings().MarketingSettings.TestEmailDomains).Returns("@myemail.com");
            var emailService = new EmailService(settings.Object);
            Assert.AreEqual(emailService.CanSendEmail("anyeamil@myemail.com"), true);
        }
        [Test]
        public void IfTheSiteInTestModeEmailAndTheEmailIsNotInTheTestDomainsItCanNotBeSent()
        {
            var settings = new Mock<IUmbracoAdventSettingsWrapper>();
            settings.Setup(x => x.Settings().MarketingSettings.EmailInTestMode).Returns(true);
            settings.Setup(x => x.Settings().MarketingSettings.TestEmailDomains).Returns("@myemail.com;@test.com;@feature.com");
            var emailService = new EmailService(settings.Object);
            Assert.AreEqual(emailService.CanSendEmail("anyeamil@this.com"), false);
        }
        [Test]
        public void IfTheSiteInTestModeEmailAndTheEmailIsInTheTestDomainsItCanBeSent()
        {
            var settings = new Mock<IUmbracoAdventSettingsWrapper>();
            settings.Setup(x => x.Settings().MarketingSettings.EmailInTestMode).Returns(true);
            settings.Setup(x => x.Settings().MarketingSettings.TestEmailDomains).Returns("@myemail.com;@test.com;@feature.com");
            var emailService = new EmailService(settings.Object);
            Assert.AreEqual(emailService.CanSendEmail("anyeamil@myemail.com"), true);
        }
    }
}
