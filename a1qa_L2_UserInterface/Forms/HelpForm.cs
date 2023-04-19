using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms
{
    internal class HelpForm : Form
    {
        private IButton SendToBottomButton => ElementFactory.GetButton(
                        By.XPath("//button[contains(@class, 'send-to-bottom-button')]"),
                                 "'Send to bottom' button");

        public HelpForm() : base(By.XPath("//div[@class='help-form']"), "Help form")
        {
        }

        internal void ClickSendToBottomButton() => SendToBottomButton.Click();

    }
}
