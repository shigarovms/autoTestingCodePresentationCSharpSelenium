using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1qa_L2_UserInterface.Steps
{
    internal class CookiesFormSteps : BaseSteps
    {
        private readonly CookiesForm cookiesForm;

        public CookiesFormSteps()
        {
            cookiesForm = new CookiesForm();
        }

        public void CookiesFormIsPresent()
        {
            LogAssertion();
            cookiesForm.AssertIsPresent();
        }

        public void CookiesFormIsHidden()
        {
            LogAssertion();
            cookiesForm.AssertIsHidden();
        }

        public void AcceptCookies()
        {
            LogStep();
            cookiesForm.ClickAcceptCookiesButton();
        }
    }
}
