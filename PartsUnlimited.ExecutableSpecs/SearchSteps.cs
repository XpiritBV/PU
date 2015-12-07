using System;

using FluentAutomation;

using PartsUnlimited.ExecutableSpecs.PageObjects;

using TechTalk.SpecFlow;
using Specflow.FluentAutomation.Ext;

namespace PartsUnlimited.ExecutableSpecs
{
    [Binding]
    public class SearchSteps
    {
        public SearchSteps()
        {
            SeleniumWebDriver.Bootstrap(
                SeleniumWebDriver.Browser.Chrome
            );
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Pages.Get<HomePage>().Go();
        }
        
        [Given(@"I have entered the keyword '(.*)'")]
        public void GivenIHaveEnteredTheKeyword(string p0)
        {
            Pages.Get<HomePage>().EnterSearchCriteria(p0);
        }
        
        [When(@"I search")]
        public void WhenISearch()
        {
            Pages.Get<HomePage>().Search();
        }
        
        [Then(@"results should contain '(.*)'")]
        public void ThenResultsShouldContain(string p0)
        {
            Pages.Get<SearchResultsPage>().FindResultByTitle(p0);
        }
    }
}
