using NUnit.Framework;
using OpenQA.Selenium;

using static SpecFlowTests.Constants.XPaths.GoogleMainPage;

namespace SpecFlowTests.PageObjects
{
    public class GoogleMainPage : BasePage
    {
        public GoogleMainPage(IWebDriver driver) : base(driver)
        {
            
        }

        private IWebElement InputSearchField => webDriver.FindElement(By.XPath(InputSearchFieldXPath));
        private IWebElement ButtonGoogleSearch => webDriver.FindElement(By.XPath(ButtonGoogleSearchXPath));

        #region Actions

        public void SetInputSearchFieldValue(string text)
        {
            InputSearchField.Clear();
            InputSearchField.SendKeys(text);
        }

        public void ClickButtonGoogleSearch()
        {
            ButtonGoogleSearch.Click();
        }

        #endregion

        #region Verification

        public void VerifyInputSearchFieldIsVisible(bool expected = true)
        {
            var actual = InputSearchField.Displayed;
            Assert.AreEqual(expected, actual, "Verify search field is visible");
        }

        public void VerifyInputSearchFieldTextIsCorrect(string expected)
        {
            var actual = InputSearchField.GetAttribute("value");
            Assert.AreEqual(expected, actual, "Verify search field is correct");
        }

        #endregion
    }
}