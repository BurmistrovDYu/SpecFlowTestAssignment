using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowTests.PageObjects
{
    public class GoogleMainPage : BasePage
    {
        public GoogleMainPage(IWebDriver driver) : base(driver)
        {
            
        }

        private IWebElement inputSearchField => webDriver.FindElement(By.XPath("//input[@role='combobox']"));
        private IWebElement buttonGoogleSearch => webDriver.FindElement(By.XPath("//div[contains(@jsaction, 'mouseout')]//input[@name='btnK' and not(ancestor::div[contains(@style, 'display:none')])]"));

        #region Actions

        public void SetInputSearchFieldValue(string text)
        {
            inputSearchField.Clear();
            inputSearchField.SendKeys(text);
        }

        public void ClickButtonGoogleSearch()
        {
            buttonGoogleSearch.Click();
        }

        #endregion

        #region Verification

        public void VerifyInputSearchFieldIsVisible(bool expected = true)
        {
            var actual = inputSearchField.Displayed;
            Assert.AreEqual(expected, actual, "Verify search field is visible");
        }

        public void VerifyInputSearchFieldTextIsCorrect(string expected)
        {
            var actual = inputSearchField.GetAttribute("value");
            Assert.AreEqual(expected, actual, "Verify search field is correct");
        }

        #endregion
    }
}