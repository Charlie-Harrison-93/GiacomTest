namespace E2EGiacomTestAutomation.Pages.CommonPage
{
    using System;
    using OpenQA.Selenium;
    using E2EGiacomTestAutomation.Utilities;
    using Utilities.Extensions;

    public partial class CommonPage
    {
        public void ClosePrivacyNote()
        {
            try
            {
                TimeSpan originalTimeout = SeleniumExecutor.Driver.Manage().Timeouts().ImplicitWait;
                SeleniumExecutor.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
                this.PrivacyPolicyCloseButton.Click();
                SeleniumExecutor.Driver.Manage().Timeouts().ImplicitWait = originalTimeout;
            }
            catch (NoSuchElementException) { }
        }

        public string GetCurrentUrl()
        {
            return SeleniumExecutor.Driver.Url;
        }

        public void NavigateToSite(string url)
        {
            SeleniumExecutor.Driver.Url = url;
        }

        public void AcceptJavaScriptAlert()
        {
            Browser.SwitchToAlert().Accept();
        }

        public void DismissJavaScriptAlert()
        {
            Browser.SwitchToAlert().Dismiss();
        }

        public void SendKeysToJavaScriptPrompt(string text)
        {
            Browser.SwitchToAlert().SendKeys(text);
        }

    }
}
