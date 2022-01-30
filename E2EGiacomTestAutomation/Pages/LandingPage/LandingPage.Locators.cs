namespace E2EGiacomTestAutomation.Pages.LandingPage
{
    using OpenQA.Selenium;

    public partial class LandingPage
    {
        public By LogoutButton => By.PartialLinkText("Logout");
        public By LoggedInConfirmationMessage => By.Id("flash");
        public By JavaScriptAlertsLink => By.LinkText("JavaScript Alerts");
        public By CheckboxesLink => By.LinkText("Checkboxes");

    }
}