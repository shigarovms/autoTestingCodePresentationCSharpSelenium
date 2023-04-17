using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Constants;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1qa_L2_UserInterface.Steps
{
    internal class AnketaTheThirdFormSteps : BaseSteps
    {
        private readonly AnketaTheThirdForm anketaTheThirdForm;

        public AnketaTheThirdFormSteps()
        {
            anketaTheThirdForm = new AnketaTheThirdForm();
        }

        public void AnketaTheThirdFormIsPresent()
        {
            LogAssertion();
            anketaTheThirdForm.AssertIsPresent();
        }
    }
}
