using SpecFlowTests.Drivers;
using SpecFlowTests.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class GoogleMainPageSteps
    {
        private readonly GoogleMainPage _googleMainPage;
        
        public GoogleMainPageSteps(Driver driver)
        {
            _googleMainPage = new GoogleMainPage(driver.CurrentDriver);
        }
        
        [Given("(.*) page is opened")]
        public void GivenWebsiteIsOpened(string url)
        {
            _googleMainPage.VerifyUrlIsCorrect(url);
        }
        
        [Given("search field is visible")]
        public void GivenSearchFieldIsVisible()
        {
            _googleMainPage.VerifyInputSearchFieldIsVisible();
        }
    }
}