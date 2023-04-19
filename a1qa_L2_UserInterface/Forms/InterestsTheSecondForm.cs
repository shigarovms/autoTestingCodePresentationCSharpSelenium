using a1qa_L2_UserInterface.Extensions;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput;

namespace a1qa_L2_UserInterface.Forms
{
    internal class InterestsTheSecondForm : Form
    {
        private ICheckBox UnselectAllCheckBox => ElementFactory.GetCheckBox(
            By.XPath("//label[@for='interest_unselectall']/span"), "Unselect all checkbox");

        private IList<ICheckBox> CheckBoxes => ElementFactory.GetNotEmptyElementList<ICheckBox>(
            By.XPath("//label[@class='checkbox__label' " +
                    "and not(contains(@for, 'interest_unselectall')) " +
                    "and not(contains(@for, 'interest_selectall'))]/span"), "CheckBoxes to select list");

        private IButton UploadButton => ElementFactory.GetButton(
            By.XPath("//a[@class='avatar-and-interests__upload-button']"), "Upload button");

        private IButton NextButton => ElementFactory.GetButton(
            By.XPath("//button[contains(text(), 'Next')]"), "NEXT button");

        public InterestsTheSecondForm() : base(By.XPath("//div[@class='avatar-and-interests']"),
                                                        "Interests form")
        {
        }

        internal ICheckBox GetCheckBoxById(int index) => CheckBoxes[index];

        internal bool IsCheckBoxChecked(int checkBoxId) => GetCheckBoxById(checkBoxId).IsChecked;

        internal void CheckNthCheckbox(int n) => CheckBoxes[n].Check();

        internal int GetCheckboxesCount() => CheckBoxes.Count;

        internal void UncheckAllCheckboxes() => UnselectAllCheckBox.Check();

        internal void ClickUploadButton() => UploadButton.Click();

        internal void ClickNextButton() => NextButton.Click();
    }
}
