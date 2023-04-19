using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;

namespace a1qa_L2_UserInterface.Steps
{
    internal class CookiesFormSteps : BaseSteps
    {
        private readonly CookiesForm cookiesForm;

        public CookiesFormSteps()
        {
            cookiesForm = new CookiesForm();
        }

        internal void CookiesFormIsPresent()
        {
            LogAssertion();
            cookiesForm.AssertIsPresent();
        }

        internal void CookiesFormIsHidden()
        {
            LogAssertion();
            cookiesForm.AssertIsNotPresent();
        }

        internal void AcceptCookies()
        {
            LogStep();
            cookiesForm.ClickAcceptCookiesButton();
        }
    }
}
