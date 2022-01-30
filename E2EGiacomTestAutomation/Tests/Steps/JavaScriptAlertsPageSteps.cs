namespace E2EGiacomTestAutomation.Tests.Steps
{
    using TechTalk.SpecFlow;
    using E2EGiacomTestAutomation.Pages.JavaScriptAlertPage;

    [Binding]
    public class JavaScriptAlertsPageSteps
    {
        private readonly JavaScriptAlertsPage javaScriptAlertsPage = new JavaScriptAlertsPage();

        [When(@"I click the 'Click for JS Alert' button")]
        public void WhenIClickTheClickForJSAlertButton()
        {
            this.javaScriptAlertsPage.ClickTheClickForJSAlertButton();
        }

        [When(@"I click the 'Click for JS Confirm' button")]
        public void WhenIClickTheClickForJSConfirmButton()
        {
            this.javaScriptAlertsPage.ClickTheClickForJSCofirmButton();
        }

        [When(@"I click the 'Click for JS Prompt' button")]
        public void WhenIClickTheClickForJSPromptButton()
        {
            this.javaScriptAlertsPage.ClickTheClickForJSPromptButton();
        }

        [Then(@"I can see the result: '(.*)'")]
        public void ThenICanSeeTheResultText(string expectedResult)
        {
            this.javaScriptAlertsPage.GetTextFromResultText(expectedResult);
        }
    }
}