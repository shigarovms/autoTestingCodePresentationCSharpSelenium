using a1qa_L2_UserInterface.Constants;
using a1qa_L2_UserInterface.Extensions;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput;
using WindowsInput.Native;

namespace a1qa_L2_UserInterface.Forms
{
    internal class InterestsTheSecondForm : Form
    {
        private readonly InputSimulator inputSimulator = new();

        private readonly Random random = new();

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

        internal void ChooseRandomCheckboxes(int count)
        {
            while (count > 0)
            {
                ICheckBox checkBox = CheckBoxes[random.Next(0, CheckBoxes.Count)];
                if (!checkBox.IsChecked)
                {
                    checkBox.Check();
                    count--;
                }
            }
        }

        internal void ClearCheckboxes()
        {
            UnselectAllCheckBox.Check();
        }

        internal void ClickUploadButton()
        {
            UploadButton.Click();
        }

        internal void UploadProfilePhoto(string pathToUploadImage)
        {
            Thread.Sleep(ProjectConstants.WaitForFileUploadDialogReady);
            inputSimulator.Keyboard.TextEntry(pathToUploadImage);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(ProjectConstants.WaitForFileUploadDialogReady);
        }

        internal void ClickNextButton()
        {
            NextButton.Click();
        }
    }
}
