using a1qa_L2_UserInterface.Base;
using a1qa_L2_UserInterface.Steps;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using NUnit.Framework;
using Test.Web.Steps;

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

        internal static readonly JsonSettingsFile config = new(@"TestData\config.json");
        internal static readonly JsonSettingsFile testData = new(@"TestData\testData.json");

        private static string UploadFile => Path.GetFullPath(
                                        testData.GetValue<string>("TC0001_AllThreeCardsAreReachable.pthToUploadedImage"));
        private static int NumberOfInterests => testData.GetValue<int>("TC0001_AllThreeCardsAreReachable.numberOfInterests");
        private static string ExpectedTimer => testData.GetValue<string>("TC0001_AllThreeCardsAreReachable.expectedTimer");

        [SetUp]
        public void Setup()
        {
            GoToPage(config.GetValue<string>("Url"));
            SetScreenExpansionMaximize();
        }

        [TearDown]
        public void AfterEach()
        {
            AqualityServices.Browser.Quit();
        }
        
        [Ignore]
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
            interestsTheSecondFormSteps.ChooseRandomInterests(NumberOfInterests);
            interestsTheSecondFormSteps.UploadProfilePhoto(UploadFile);
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
            helpFormSteps.HelpFormIsNotPresent();
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
            Assert.That(welcomePageSteps.TimerStartsFrom(), Does.Contain(ExpectedTimer));

        }
    }
}
