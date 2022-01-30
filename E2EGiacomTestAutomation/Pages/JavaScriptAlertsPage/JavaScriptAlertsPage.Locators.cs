namespace E2EGiacomTestAutomation.Pages.JavaScriptAlertPage
{
    using OpenQA.Selenium;

    public partial class JavaScriptAlertsPage
    {
        public By ClickForJSAlertButton => By.CssSelector("[onclick = 'jsAlert()']");
        public By ClickForJSCofirmButton => By.CssSelector("[onclick = 'jsConfirm()']");
        public By ClickForJSPromptButton => By.CssSelector("[onclick = 'jsPrompt()']");
        public By ResultText => By.Id("result");
    }
}