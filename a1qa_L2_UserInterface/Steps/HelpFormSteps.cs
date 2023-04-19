using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;

namespace a1qa_L2_UserInterface.Steps
{
    internal class HelpFormSteps : BaseSteps
    {
        private readonly HelpForm helpForm;

        public HelpFormSteps()
        {
            helpForm = new HelpForm();
        }

        internal void HelpFormIsPresent()
        {
            LogAssertion();
            helpForm.AssertIsPresent();
        }

        internal void HelpFormIsNotPresent()
        {
            LogAssertion();
            helpForm.AssertIsNotPresent();
        }

        internal void HideHelpForm()
        {
            LogStep();
            helpForm.ClickSendToBottomButton();
        }
    }
}
