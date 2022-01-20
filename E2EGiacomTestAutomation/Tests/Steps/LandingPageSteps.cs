namespace E2EGiacomTestAutomation.Tests.Steps
{
    using FluentAssertions;
    using Pages.LoginPage;
    using E2EGiacomTestAutomation.Utilities.Extensions;
    using TechTalk.SpecFlow;
    using Utilities;
    using Utilities.Helpers.TestDataGenerator;
    using Utilities.Enums;
    using E2EGiacomTestAutomation.Pages.CommonPage;
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
    }
}