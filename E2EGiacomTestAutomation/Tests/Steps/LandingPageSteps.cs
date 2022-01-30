namespace E2EGiacomTestAutomation.Tests.Steps
{
    using TechTalk.SpecFlow;
    using E2EGiacomTestAutomation.Pages.LandingPage;

    [Binding]
    public class LandingPageSteps
    {
        private readonly LandingPage landingPage = new LandingPage();

        [When(@"I click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            this.landingPage.LogOut();
        }

        [Given(@"I have clicked the JavaScript Alerts link")]
        public void IHaveClickedTheJavaScriptAlertsLink()
        {
            this.landingPage.ClickTheJavaScriptAlertsLink();
        }

        [Given(@"I have clicked the Checkboxes link")]
        public void IHaveClickedTheCheckboxesLink()
        {
            this.landingPage.ClickTheCheckboxesLink();
        }
    }
}