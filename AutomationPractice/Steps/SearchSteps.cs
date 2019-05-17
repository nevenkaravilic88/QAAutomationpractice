using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class SearchSteps  : Base
    {
        [StepDefinition(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            ScenarioContext.Current.Pending();
        }
        
        [StepDefinition(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            Utilities ut = new Utilities(Driver);
           // HomePage hp = new HomePage(Driver);
         //   ut.ClickOnElement(hp.searchBtn);
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

        [Given(@"user enters a '(.*)' search term")]
        public void GivenUserEntersASearchTerm(string term)
        {
            Utilities ut = new Utilities(Driver);
            //HomePage hp = new Homepage(Driver);
           // ut.EnterTextElement(hp.searchFld, term);
        }

       
        [Then(@"results for a '(.*)' term are displayed")]
        public void ThenResultsForATermAreDisplayed(string term)
        {
            Utilities ut = new Utilities(Driver);
            SearchPage srp = new SearchPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchTerm), Does.Contain(term), "Search results for the required term are not displayed");
        }

    }
}
