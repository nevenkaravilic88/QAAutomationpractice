using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"cart page is opened")]
        public void ThenCartPageIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
