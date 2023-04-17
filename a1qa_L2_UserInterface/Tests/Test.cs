using Aquality.Selenium.Browsers;
using NUnit.Framework;
using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Constants;
using a1qa_L2_UserInterface.Models;
using a1qa_L2_UserInterface.Utilities;
using Test.Web.Steps;
using a1qa_L2_UserInterface.Steps;

namespace a1qa_L2_UserInterface.Tests
{
    public class Test : BaseTest
    {
        private readonly WelcomePageSteps welcomePageSteps = new();
        private readonly LoginTheFirstFormSteps loginTheFirstFormSteps = new();
        private readonly InterestsTheSecondFormSteps interestsTheSecondFormSteps = new();
        private readonly AnketaTheThirdFormSteps anketaTheThirdFormSteps = new();
        private readonly HelpFormSteps helpFormSteps = new();
        private readonly CookiesFormSteps cookiesFormSteps = new();

        private readonly TestData testData = FileReader.ReadJsonData<TestData>(ProjectConstants.PathToTestData);

        [SetUp]
        public void Setup()
        {
            GoToPage(testData.Url);
            SetScreenExpansionMaximize();
        }

        [TearDown]
        public void AfterEach()
        {
            AqualityServices.Browser.Quit();
        }

        [Test(Description = "TC-0001 All three cards are reachable")]
        public void TC0001_AllThreeCardsAreReachable()
        {
            welcomePageSteps.WelcomePageIsPresent();
            welcomePageSteps.ClickHereTextLikeButton();
            loginTheFirstFormSteps.LoginTheFirstFormIsPresent();
            loginTheFirstFormSteps.InputCredentionals();
            loginTheFirstFormSteps.ClickTLDomainSelection();
            loginTheFirstFormSteps.SetTLDomainName();
            loginTheFirstFormSteps.UncheckTermsAndCondsCheckBox();
            loginTheFirstFormSteps.ClickLoginNextButton();
            interestsTheSecondFormSteps.InterestsTheSecondFormIsPresent();
            interestsTheSecondFormSteps.Choose2randomInterests();
            interestsTheSecondFormSteps.UploadProfilePhoto();
            interestsTheSecondFormSteps.ClickNextButton();
            anketaTheThirdFormSteps.AnketaTheThirdFormIsPresent();
        }

        [Test(Description = "TC-0002 Help form is hibable")]
        public void TC0002_HelpFormIsHibable()
        {
            welcomePageSteps.WelcomePageIsPresent();
            welcomePageSteps.ClickHereTextLikeButton();
            helpFormSteps.HelpFormIsPresent();
            helpFormSteps.HideHelpForm();
            helpFormSteps.HelpFormIsHidden();
        }

        [Test(Description = "TC-0003 Cookies form disappears after accepting them")]
        public void TC0003_CookiesFormDisappearsAfterAcceptingThem()
        {
            welcomePageSteps.WelcomePageIsPresent();
            welcomePageSteps.ClickHereTextLikeButton();
            cookiesFormSteps.CookiesFormIsPresent();
            cookiesFormSteps.AcceptCookies();
            cookiesFormSteps.CookiesFormIsHidden();
        }

        [Test(Description = "TC-0004 Timer starts from zeroes")]
        public void TC0004_TimerStartsFromZeroes()
        {
            welcomePageSteps.WelcomePageIsPresent();
            welcomePageSteps.ClickHereTextLikeButton();
            Assert.That(welcomePageSteps.TimerStartsFrom(), Is.EqualTo("00:00"));
            
        }
    }
}