namespace E2EGiacomTestAutomation.Pages.CheckboxesPage
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

    public partial class CheckboxesPage : CommonPage
    {
        public void ClickTheUnSelectedCheckbox1()
        {
            bool isSelected = this.Checkbox1.GetElement().Selected;
            if (!isSelected) this.Checkbox1.ClickWithWait();
        }

        public void Checkbox1IsNotSelected()
        {
            bool isSelected = this.Checkbox1.GetElement().Selected;
            isSelected.Should().BeFalse();
        }

        public void ClickTheSelectedCheckbox2()
        {
            bool isSelected = this.Checkbox2.GetElement().Selected;
            if (isSelected) this.Checkbox2.ClickWithWait();
        }

        public void Checkbox2IsSelected()
        {
            bool isSelected = this.Checkbox2.GetElement().Selected;
            isSelected.Should().BeTrue();
        }
    }
}
