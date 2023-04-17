using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace a1qa_L2_UserInterface.Forms
{
    internal class AnketaTheThirdForm : Form
    {
        public AnketaTheThirdForm() : base(By.XPath("//div[@class='personal-details']"),
                                                        "Anketa form")
        {
        }
    }
}
