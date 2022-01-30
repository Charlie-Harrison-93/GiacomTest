namespace E2EGiacomTestAutomation.Tests.Steps
{
    using TechTalk.SpecFlow;
    using E2EGiacomTestAutomation.Pages.CheckboxesPage;

    [Binding]
    public class CheckboxesPageSteps
    {
        private readonly CheckboxesPage checkboxesPage = new CheckboxesPage();

        [When(@"I un-check checkbox 2")]
        public void WhenIUnCheckCheckbox2()
        {
            this.checkboxesPage.ClickTheSelectedCheckbox2();
        }

        [When(@"I check checkbox 1")]
        public void WhenICheckCheckbox1()
        {
            this.checkboxesPage.ClickTheUnSelectedCheckbox1();
        }

        [Then(@"I see that checkbox 2 is checked")]
        public void ThenISeeThatCheckbox2IsChecked()
        {
            this.checkboxesPage.Checkbox2IsSelected();
        }

        [Then(@"I can see that checkboxes are in the default state")]
        public void ThenICanSeeThatCheckboxesAreInTheDefaultState()
        {
            this.checkboxesPage.Checkbox2IsSelected();
            this.checkboxesPage.Checkbox1IsNotSelected();
        }
    }
}