namespace E2EGiacomTestAutomation.Pages.CheckboxesPage
{
    using OpenQA.Selenium;

    public partial class CheckboxesPage
    {
        public By Checkbox1 => By.XPath("//input[@type = 'checkbox'][1]");
        public By Checkbox2 => By.XPath("//input[@type = 'checkbox'][2]");
    }
}