using Aquality.Selenium.Forms;
using NUnit.Framework;

namespace a1qa_L2_UserInterface.Extensions
{
    public static class FormExtensions
    {
        public static void AssertIsPresent(this Form form)
        {
            Assert.IsTrue(form.State.WaitForDisplayed(), $"{form.Name} should be presented");
        }

        public static void AssertIsHidden(this Form form)
        {
            Assert.IsTrue(form.State.WaitForNotDisplayed(), $"{form.Name} should not be presented");
        }
    }
}
