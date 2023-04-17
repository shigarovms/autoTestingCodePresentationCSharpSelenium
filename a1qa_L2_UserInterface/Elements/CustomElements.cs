using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Elements
{
    public class CustomElements
    {
        public class CustomTextBox : TextBox
        {
            public CustomTextBox(By locator, string name, ElementState state) : base(locator, name, state)
            {
            }

            public new string Text => Value;
        }
    }
}
