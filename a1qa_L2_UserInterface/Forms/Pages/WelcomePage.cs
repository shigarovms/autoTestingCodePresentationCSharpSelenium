using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms.Pages
{
    public class WelcomePage : Form
    {
        private IButton HereTextLikeButton => ElementFactory.GetButton(By.XPath("//a[@class='start__link']"),
                                                                                "Here text like button");

        private ILabel Timer => ElementFactory.GetLabel(
                                    By.XPath("//div[contains(@class, 'timer')]"), "Timer");

        public WelcomePage() : base(By.XPath("//img[@src='images/verhaert-digital-logo.svg']"),
                                                "Welcome page")
        {
        }

        internal void ClickHereTextLikeButton() => HereTextLikeButton.Click();

        internal string TimerStartsFrom() => Timer.Text;

    }
}
