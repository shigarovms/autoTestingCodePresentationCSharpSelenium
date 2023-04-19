using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms
{
    internal class CookiesForm : Form
    {
        private IButton AcceptCookiesButton => ElementFactory.GetButton(
                        By.XPath("//button[@class='button button--solid button--transparent']"),
                                 "'Accept cookies' button");

        public CookiesForm() : base(By.XPath("//div[@class='cookies']"), "Cookies form")
        {
        }

        internal void ClickAcceptCookiesButton() => AcceptCookiesButton.Click();
    }
}
