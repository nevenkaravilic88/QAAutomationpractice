using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        public object MyAccount { get; private set; }
        public object Asseet { get; private set; }

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters cirrect credentials")]
        public void GivenEntersCirrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextElement(ap.username,TestConstants.Username);
            ut.EnterTextElement(ap.password, TestConstants.Password);
        }
        
        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.singinbtn);

        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Myaccount ma = new Myaccount(Driver);
            Assert.True(ut.ElementDisplayed(ma.signoutbtn), "User is not logged in");
        }

        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Myaccount ma = new Myaccount(Driver);
            ut.ClickOnElement(ma.wishlists);
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            MyWishlistpage ma = new MyWishlistpage(Driver);
            Assert.True(ut.ElementDisplayed(ma.wishlists), "User cannot add wishlist");
        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GeneraterandomEmail();
            ut.EnterTextElement(ap.emailaddress, email);
            ut.ClickOnElement(ap.createanaccount);
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            SearchPage sp = new SearchPage(Driver);
            ut.EnterTextElement(sp.search);
        }

        [Given(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            SearchPage sp = new SearchPage(Driver);
            ut.ClickOnElement(sp.search);
        }

        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            SearchPage sp = new SearchPage(Driver);
            Assert.True(ut.ElementDisplayed(sp.search), "User can not open the product");

        }

        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {

            SearchPage sp = new SearchPage(Driver);
            ut.ClickOnElement(sp.search);
        }

        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            SearchPage sp = new SearchPage(Driver);
            ut.ClickOnElement(sp.search);
        }

        [Then(@"cart page is opened")]
        public void ThenCartPageIsOpened()
        {
            SearchPage sp = new SearchPage(Driver);
            Assert.True(ut.ElementDisplayed(sp.search), "User can not open the station");

        }

    }


}
