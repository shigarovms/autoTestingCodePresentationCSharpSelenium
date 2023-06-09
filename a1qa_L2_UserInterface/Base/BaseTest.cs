﻿using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Logging;
using Humanizer;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace a1qa_L2_UserInterface.Base
{
    public abstract class BaseTest
    {
        protected string ScenarioName
            => TestContext.CurrentContext.Test.Properties.Get("Description")?.ToString()
            ?? TestContext.CurrentContext.Test.Name.Replace("_", string.Empty).Humanize();

        private static Logger Logger => Logger.Instance;

        private TestContext.ResultAdapter Result => TestContext.CurrentContext.Result;

        [SetUp]
        public void BaseSetup()
        {
            Logger.Info($"Start scenario [{ScenarioName}]");
        }

        [TearDown]
        public virtual void BaseAfterEach()
        {
            LogScenarioResult();
        }

        public void SetScreenExpansionMaximize()
        {
            AqualityServices.Browser.Maximize();
        }

        public void GoToPage(string url)
        {
            AqualityServices.Browser.GoTo(url);
        }

        private void LogScenarioResult()
        {
            Logger.Info($"Scenario [{ScenarioName}] result is {Result.Outcome.Status}!");
            if (Result.Outcome.Status != TestStatus.Passed)
            {
                Logger.Error(Result.Message);
            }
            Logger.Info(new string('=', 100));
        }
    }
}