using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using WindowsInput;
using WindowsInput.Native;

namespace a1qa_L2_UserInterface.Forms
{


    internal class InterestsTheSecondForm : Form
    {
        private InputSimulator inputSimulator = new();

        private ICheckBox UnselectAllCheckBox => ElementFactory.GetCheckBox(
            By.XPath("//label[@for='interest_unselectall']/span"), "Unselect all checkbox");

        private ICheckBox FirstCheckBox => ElementFactory.GetCheckBox(
            By.XPath("//label[@for='interest_questions']/span"), "First checkbox");

        private ICheckBox SecondCheckBox => ElementFactory.GetCheckBox(
            By.XPath("//label[@for='interest_dough']/span"), "Second checkbox");

        private IButton UploadButton => ElementFactory.GetButton(
            By.XPath("//a[@class='avatar-and-interests__upload-button']"), "Upload button");

        private IButton NextButton => ElementFactory.GetButton(
            By.XPath("//button[contains(text(), 'Next')]"), "NEXT button");

        public InterestsTheSecondForm() : base(By.XPath("//div[@class='avatar-and-interests']"), 
                                                        "Interests form") 
        { 
        }

        internal void ChooseCheckbox1()
        {
            FirstCheckBox.Check();
        }

        internal void ChooseCheckbox2()
        {
           SecondCheckBox.Check();
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
            Thread.Sleep(1000);
            inputSimulator.Keyboard.TextEntry(pathToUploadImage);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        internal void ClickNextButton()
        {
            NextButton.Click();
        }
    }
}
