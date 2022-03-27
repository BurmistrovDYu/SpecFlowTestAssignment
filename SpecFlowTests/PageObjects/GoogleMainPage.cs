using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowTests.PageObjects
{
    public class GoogleMainPage : BasePage
    {
        GoogleMainPage(IWebDriver driver) : base(driver)
        {
            
        }

        private IWebElement inputSearchField => webDriver.FindElement(By.XPath("//input[@role='combobox']"));

        #region Actions

        

        #endregion

        #region Verification

        public void VerifyInputSearchFieldIsVisible(bool expected = true)
        {
            var actual = inputSearchField.Displayed;
            Assert.AreEqual(expected, actual, "Verify search field is visible");
        }

        #endregion
    }
}