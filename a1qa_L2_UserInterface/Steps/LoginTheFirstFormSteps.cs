using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Constants;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;
using a1qa_L2_UserInterface.Models;
using a1qa_L2_UserInterface.Utilities;

namespace a1qa_L2_UserInterface.Steps
{
    internal class LoginTheFirstFormSteps : BaseSteps
    {
        private readonly LoginTheFirstForm loginTheFirstForm;

        public LoginTheFirstFormSteps()
        {
            loginTheFirstForm = new LoginTheFirstForm();
        }

        public void LoginTheFirstFormIsPresent()
        {
            LogAssertion();
            loginTheFirstForm.AssertIsPresent();
        }

        public void SetUserName(string userName)
        {
            LogStep(nameof(SetUserName) + $"Input user name - [{userName}]");
            loginTheFirstForm.SetUserName(userName);
        }

        public void SetDomain(string userDomain)
        {
            LogStep(nameof(SetDomain) + $"Input user domain - [{userDomain}]");
            loginTheFirstForm.SetDomain(userDomain);
        }

        public void SetPassword(string password)
        {
            LogStep(nameof(SetPassword) + $"Input password - [{password}]");
            loginTheFirstForm.SetPassword(password);
        }

        public void InputCredentionals()
        {
            string password = PasswordGenerator.GeneratePassword();
            SetUserName(password);
            SetDomain(password);
            SetPassword(password);
        }

        public void ClickTLDomainSelection()
        {
            LogStep();
            loginTheFirstForm.ClickTLDomainNameSelection();
        }

        public void SetTLDomainName()
        {
            LogStep(nameof(SetTLDomainName) + $"Set random top-level domain name");
            loginTheFirstForm.SetTLDomainName();
        }

        internal void UncheckTermsAndCondsCheckBox()
        {
            LogStep();
            loginTheFirstForm.UncheckTermsAndCondsCheckBox();
        }

        internal void ClickLoginNextButton()
        {
            LogStep();
            loginTheFirstForm.ClickLoginNextButton();
        }
    }
}