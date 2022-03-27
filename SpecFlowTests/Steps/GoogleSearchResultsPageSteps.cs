using SpecFlowTests.Drivers;
using SpecFlowTests.PageObjects;
using TechTalk.SpecFlow;

using static SpecFlowTests.Constants.Urls;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class GoogleSearchResultsPageSteps
    {
        private readonly GoogleSearchResultsPage _googleSearchResultsPage;

        public GoogleSearchResultsPageSteps(Driver driver)
        {
            _googleSearchResultsPage = new GoogleSearchResultsPage(driver.CurrentDriver);
        }

        [Then("search results page is opened")]
        public void ThenSearchResultsPageIsOpened()
        {
            _googleSearchResultsPage.VerifyUrlContainsText(GoogleSearchPageUrl);
        }

        [Then("first (\\d+) results contain '(.*)'")]
        public void ThenFirstNumberOfResultsContainsText(int numberOfResults, string text)
        {
            _googleSearchResultsPage.VerifyFirstAmountOfSearchResultsContainText(numberOfResults, text);
        }
    }
}