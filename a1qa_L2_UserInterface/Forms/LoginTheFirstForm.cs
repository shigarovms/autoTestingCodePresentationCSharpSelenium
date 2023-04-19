using a1qa_L2_UserInterface.Extensions;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms
{
    internal class LoginTheFirstForm : Form
    {
        private readonly Random random = new();
        private IButton LoginInNextButton =>
            ElementFactory.GetButton(By.LinkText("Next"), "Login in next");

        private ITextBox UserNameTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Your email']"), "User name");

        private ITextBox DomainTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Domain']"), "Domain");

        private ITextBox PasswordTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Choose Password']"), "Password");

        private ILabel TLDomainNameSelectionLabel => ElementFactory.GetLabel(
            By.XPath("//div[@class='dropdown__header']"), "Top-level domain name selection");

        private IList<ILink> TLDomainNameLinks => ElementFactory.GetNotEmptyElementList<ILink>(
            By.XPath($"//div[@class='dropdown__list-item']"), "TLDomain names");

        private ICheckBox TermsAndCondsCheckBox =>
            ElementFactory.GetCheckBox(By.XPath("//span[@class='icon icon-check checkbox__check']"),
                                                "Terms & conditions checkbox");

        public LoginTheFirstForm() : base(By.XPath("//div[@class='login-form']"),
                                                    "Login the first form")
        {
        }

        internal void ClickLoginNextButton() => LoginInNextButton.Click();

        internal void SetUserName(string userName) => UserNameTextBox.ClearAndType(userName);

        internal void SetDomain(string userDomain) => DomainTextBox.ClearAndType(userDomain);

        internal void SetPassword(string userPassword) => PasswordTextBox.ClearAndType(userPassword);

        internal void ClickTLDomainNameSelection() => TLDomainNameSelectionLabel.Click();

        internal void SetTLDomainName()
        {
            TLDomainNameLinks[random.Next(0, TLDomainNameLinks.Count)].Click();
        }

        internal void UncheckTermsAndCondsCheckBox()
        {
            TermsAndCondsCheckBox.Check();
        }
    }
}
