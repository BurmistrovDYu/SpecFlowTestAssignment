using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

using static SpecFlowTests.Constants.XPaths.GoogleSearchResultsPage;

namespace SpecFlowTests.PageObjects
{
    public class GoogleSearchResultsPage : BasePage
    {
        GoogleSearchResultsPage(IWebDriver driver) : base(driver)
        {
            
        }

        private List<IWebElement> SearchResults => webDriver.FindElements(By.XPath(SearchResultsXPath)).ToList();

        #region Verification

        public void VerifyFirstAmountOfSearchResultsContainText(int numberOfResults, string text, bool expected = true)
        {
            List<bool> expectedList = Enumerable.Repeat(expected, numberOfResults).ToList();
            List<bool> actualList = new List<bool>();
            for (var i = 0; i < numberOfResults; i++)
            {
                var actual = SearchResults[i].Text.ToLower().Contains(text.ToLower());
                actualList.Add(actual);
            }
            Assert.AreEqual(expectedList, actualList, $"Verify that first {numberOfResults} contain {text}");
        }

        #endregion
    }
}