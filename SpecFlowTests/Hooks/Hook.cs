using System;
using BoDi;
using SpecFlowTests.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void GoogleSearchSetup(ObjectContainer container)
        {
            var driver = container.Resolve<Driver>();
            driver.CurrentDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.CurrentDriver.Manage().Window.Maximize();
            driver.CurrentDriver.Url = "https://www.google.com";
        }

        [AfterScenario]
        public static void GoogleSearchTeardown(ObjectContainer container)
        {
            var driver = container.Resolve<Driver>();
            driver.Dispose();
        }
    }
}