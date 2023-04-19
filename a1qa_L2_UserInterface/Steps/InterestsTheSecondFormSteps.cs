using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;
using a1qa_L2_UserInterface.Utilities;

namespace a1qa_L2_UserInterface.Steps
{
    internal class InterestsTheSecondFormSteps : BaseSteps
    {
        private readonly InterestsTheSecondForm interestsTheSecondForm;

        public InterestsTheSecondFormSteps()
        {
            interestsTheSecondForm = new InterestsTheSecondForm();
        }

        public void InterestsTheSecondFormIsPresent()
        {
            LogAssertion();
            interestsTheSecondForm.AssertIsPresent();
        }
        // random to helper class
        internal void CheckRandomCheckBoxes(int count)
        {
            LogStep();
            int checkboxesCount = interestsTheSecondForm.GetCheckboxesCount();
            while (count > 0)
            {
                int checkBoxId = RandomHelper.GetRandomNumberFromRange(checkboxesCount);
                if (!interestsTheSecondForm.IsCheckBoxChecked(checkBoxId))
                {
                    interestsTheSecondForm.CheckNthCheckbox(checkBoxId);
                    count--;
                }
            }
        }

        internal void ChooseRandomInterests(int count)
        {
            LogStep();
            interestsTheSecondForm.UncheckAllCheckboxes();
            CheckRandomCheckBoxes(count);
        }

        internal void ClickNextButton()
        {
            LogStep();
            interestsTheSecondForm.ClickNextButton();
        }

        internal void UploadProfilePhoto(string uploadFile)
        {
            LogStep();
            interestsTheSecondForm.ClickUploadButton();
            InputSimulatorHelper.UploadImage(uploadFile);
        }
    }
}
