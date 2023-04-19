using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;

namespace a1qa_L2_UserInterface.Steps
{
    internal class AnketaTheThirdFormSteps : BaseSteps
    {
        private readonly AnketaTheThirdForm anketaTheThirdForm;

        public AnketaTheThirdFormSteps()
        {
            anketaTheThirdForm = new AnketaTheThirdForm();
        }

        internal void AnketaTheThirdFormIsPresent()
        {
            LogAssertion();
            anketaTheThirdForm.AssertIsPresent();
        }
    }
}
