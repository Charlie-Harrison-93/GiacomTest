namespace E2EGiacomTestAutomation.Pages.JavaScriptAlertPage
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

    public partial class JavaScriptAlertsPage : CommonPage
    {
        public void ClickTheClickForJSAlertButton()
        {
            this.ClickForJSAlertButton.ClickWithWait();
        }

        public void ClickTheClickForJSCofirmButton()
        {
            this.ClickForJSCofirmButton.ClickWithWait();
        }

        public void ClickTheClickForJSPromptButton()
        {
            this.ClickForJSPromptButton.ClickWithWait();
        }

        public void GetTextFromResultText(string expectedText)
        {
            string actualText = this.ResultText.GetElement().Text;
            actualText.Should().Be(expectedText);
        }
    }
}
