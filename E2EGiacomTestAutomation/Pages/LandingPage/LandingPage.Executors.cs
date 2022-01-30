namespace E2EGiacomTestAutomation.Pages.LandingPage
{
    using System;
    using OpenQA.Selenium;
    using E2EGiacomTestAutomation.Utilities;
    using Utilities.Extensions;
    using PGSWebsite.Configuration.TestDataSection;
    using Pages.CommonPage;
    using FluentAssertions;
    using Utilities.Helpers.TestDataGenerator;
    using Utilities.Enums;

    public partial class LandingPage : CommonPage
    {
        public void LogOut()
        {
            this.LogoutButton.ClickWithWait();
        }

        public void ClickTheJavaScriptAlertsLink()
        {
            this.JavaScriptAlertsLink.ClickWithWait();
        }

        public void ClickTheCheckboxesLink()
        {
            this.CheckboxesLink.ClickWithWait();
        }
    }
}
