namespace E2EGiacomTestAutomation.Tests.Steps
{
    using FluentAssertions;
    using E2EGiacomTestAutomation.Pages.CommonPage;
    using E2EGiacomTestAutomation.Utilities;
    using E2EGiacomTestAutomation.Utilities.Extensions;
    using TechTalk.SpecFlow;

    [Binding]
    public class CommonSteps
    {
        private CommonPage commonPage = new CommonPage();

        [When(@"I click the 'OK' button on the JavaScript Alert")]
        public void IClickTheOKButtonOnTheJavaScriptAlert()
        {
            this.commonPage.AcceptJavaScriptAlert();
        }

        [When(@"I click the 'Cancel' button on the JavaScript Alert")]
        public void IClickTheCancelButtonOnTheJavaScriptAlert()
        {
            this.commonPage.DismissJavaScriptAlert();
        }

        [When(@"I send the text '(.*)' to the JavaScript Prompt")]
        public void ISendTheTextOnTheJavaScriptAlert(string text)
        {
            this.commonPage.SendKeysToJavaScriptPrompt(text);
        }

        [When(@"I refresh the page")]
        public void WhenIRefreshThePage()
        {
            Browser.RefreshPage();
        }

        [Then(@"I can see expected page ""(.*)""")]
        public void ThenICanSeeExpectedPage(string pageTitle)
        {
            this.commonPage.PageTitle(pageTitle).IsDisplayedAfterWait().Should().BeTrue();
        }

        [Then(@"I can see expected page ""(.*)"" in a new tab")]
        public void ThenICanSeeExpectedPageInNewTab(string pageTitle)
        {
            Browser.SwitchToWindowHandle(SeleniumExecutor.Driver.WindowHandles.Count - 1);
            try
            {
                this.commonPage.PageHeader(pageTitle).IsDisplayedAfterWait().Should().BeTrue();
            }
            finally
            {
                Browser.CloseTab();
                Browser.SwitchToWindowHandle(0);
                Browser.ResizeToFullScreen();
            }
        }
    }
}