﻿using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Constants;
using a1qa_L2_UserInterface.Extensions;
using a1qa_L2_UserInterface.Forms;

namespace a1qa_L2_UserInterface.Steps
{
    internal class InterestsTheSecondFormSteps : BaseSteps
    {
        private readonly InterestsTheSecondForm interestsTheSecondForm;
        private readonly string uploadFile;

        public InterestsTheSecondFormSteps()
        {
            interestsTheSecondForm = new InterestsTheSecondForm();
            uploadFile = Path.GetFullPath(ProjectConstants.PathToUploadImage);
        }

        public void InterestsTheSecondFormIsPresent()
        {
            LogAssertion();
            interestsTheSecondForm.AssertIsPresent();
        }

        internal void Choose2randomInterests()
        {
            LogStep();
            interestsTheSecondForm.ClearCheckboxes();
            interestsTheSecondForm.ChooseCheckbox1();
            interestsTheSecondForm.ChooseCheckbox2();
        }

        internal void ClickNextButton()
        {
            LogStep();
            interestsTheSecondForm.ClickNextButton();
        }

        internal void UploadProfilePhoto()
        {
            LogStep();
            interestsTheSecondForm.ClickUploadButton();
            interestsTheSecondForm.UploadProfilePhoto(uploadFile);
        }
    }
}
