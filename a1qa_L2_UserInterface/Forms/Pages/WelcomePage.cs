using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace a1qa_L2_UserInterface.Forms.Pages
{
    public class WelcomePage : Form
    {
        private IButton HereTextLikeButton => ElementFactory.GetButton(By.XPath("//a[@class='start__link']"), 
                                                                                "Here text like button");

        private ILabel Timer => ElementFactory.GetLabel(
                                    By.XPath("//div[@class='timer timer--white timer--center']"), "Timer");

        public WelcomePage() : base(By.XPath("//*[@id='app']/div[@class='bagaar-link']" +
                                                "/img[@src='images/verhaert-digital-logo.svg']"), 
                                                "Welcome page")
        {
        }

        public void ClickHereTextLikeButton() => HereTextLikeButton.Click();

        internal string TimerStartsFrom() => Timer.Text;

    }
}
