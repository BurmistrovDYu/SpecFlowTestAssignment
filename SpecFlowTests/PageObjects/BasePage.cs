using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowTests.PageObjects
{
    public class BasePage
    {
        protected readonly IWebDriver webDriver;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Actions

        public void OpenUrl(string url)
        {
            if (webDriver.Url != url)
            {
                webDriver.Url = url;
            }
        }

        #endregion

        #region Verification

        public void VerifyUrlIsCorrect(string expected)
        {
            var actual = webDriver.Url;
            Assert.AreEqual(expected, actual, "Verify url is correct");
        }

        #endregion
    }
}