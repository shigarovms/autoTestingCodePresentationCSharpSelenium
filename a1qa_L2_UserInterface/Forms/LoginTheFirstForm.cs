using a1qa_L2_UserInterface.Enums;
using a1qa_L2_UserInterface.Extensions;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms
{
    internal class LoginTheFirstForm : Form
    {
        private IButton LoginInNextButton => 
            ElementFactory.GetButton(By.LinkText("Next"), "Login in next");

        private By TLDomainNameLocator(TLDomainName tldn) => 
            By.XPath($"//div[text()=\"{tldn.GetEnumDescription()}\"]");

        private ITextBox UserNameTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Your email']"), "User name");

        private ITextBox DomainTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Domain']"), "Domain");

        private ITextBox PasswordTextBox => ElementFactory.GetTextBox(
            By.XPath("//input[@placeholder='Choose Password']"), "Password");

        private ILabel TLDomainNameSelectionLabel => ElementFactory.GetLabel(
            By.XPath("//div[@class='dropdown__header']"), "Top-level domain name selection");

        private IList<ILink> TLDomainNameLinks => ElementFactory.GetNotEmptyElementList<ILink>(
            By.XPath($"//div[contains(@class,'dropdown__list-item')]"), "TLDomain names");

        private ILink TLDomainNameLink(TLDomainName tldm) => 
            ElementFactory.GetLink(TLDomainNameLocator(tldm), "TLDomain name");

        private ICheckBox TermsAndCondsCheckBox => 
            ElementFactory.GetCheckBox(By.XPath("//span[@class='icon icon-check checkbox__check']"), 
                                                "Terms & conditions checkbox");

        public LoginTheFirstForm() : base(By.XPath("//div[@class='login-form']"),
                                                    "Login the first form")
        {
        }

        public void ClickLoginNextButton() => LoginInNextButton.Click();

        public void SetUserName(string userName) => UserNameTextBox.ClearAndType(userName);

        public void SetDomain(string userDomain) => DomainTextBox.ClearAndType(userDomain);

        public void SetPassword(string userPassword) => PasswordTextBox.ClearAndType(userPassword);

        public void ClickTLDomainNameSelection() => TLDomainNameSelectionLabel.Click();

        public IList<string> GetLanguageCountries()
        {
            var tempList = TLDomainNameLinks;
            return TLDomainNameLinks.Select(item => item.Text).ToList();
        }

        public void SetTLDomainName(TLDomainName tldn)
        {
            TLDomainNameLink(tldn).Click();
        }

        internal void UncheckTermsAndCondsCheckBox()
        {
            TermsAndCondsCheckBox.Check();
        }
    }
}
