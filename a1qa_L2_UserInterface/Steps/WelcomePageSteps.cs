using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms.Pages;

namespace Test.Web.Steps
{
    public class WelcomePageSteps : BaseSteps
    {
        private readonly WelcomePage welcomePage;

        public WelcomePageSteps()
        {
            welcomePage = new WelcomePage();
        }

        public void WelcomePageIsPresent()
        {
            LogAssertion();
            welcomePage.AssertIsPresent();
        }

        public void ClickHereTextLikeButton()
        {
            LogStep();
            welcomePage.ClickHereTextLikeButton();
        }

        internal string TimerStartsFrom()
        {
            LogStep();
            return welcomePage.TimerStartsFrom();
        }
    }
}
