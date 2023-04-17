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
    internal class HelpFormSteps : BaseSteps
    {
        private readonly HelpForm helpForm;

        public HelpFormSteps()
        {
            helpForm = new HelpForm();
        }

        public void HelpFormIsPresent()
        {
            LogAssertion();
            helpForm.AssertIsPresent();
        }

        public void HelpFormIsHidden()
        {
            LogAssertion();
            helpForm.AssertIsHidden();
        }

        public void HideHelpForm()
        {
            LogStep();
            helpForm.ClickSendToBottomButton();
        }
    }
}
