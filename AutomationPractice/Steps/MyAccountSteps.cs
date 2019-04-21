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
            CreateAnAccountPage cap = new CreateAnAccountPage(Driver);
            ut.EnterTextElement(cap.firstname, TestConstants.Firstname);
            ut.EnterTextElement(cap.lastname, TestConstants.Lastname);
            string fullname = TestConstants.Firstname + " " + TestConstants.Lastname;
            ScenarioContext.Current.Add(TestConstants.FullName, fullname);
            ut.EnterTextElement(cap.password, TestConstants.Password);
            ut.EnterTextElement(cap.adFirstName, TestConstants.Firstname);
            ut.EnterTextElement(cap.adLastName, TestConstants.Lastname);
            ut.EnterTextElement(cap.address, TestConstants.Adress);
            ut.EnterTextElement(cap.city, TestConstants.City);
            ut.DropdownSelect(cap.state, TestConstants.State);
            ut.EnterTextElement(cap.zipCode, TestConstants.ZipCode);
            ut.EnterTextElement(cap.phone, TestConstants.Mobile);
            ut.EnterTextElement(cap.alias, TestConstants.Alias);

        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            CreateAnAccountPage cap = new CreateAnAccountPage(Driver);
            ut.ClickOnElement(cap.RegisterBtn);
        }

                
        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            string fullName = ScenarioContext.Current.Get<string>(TestConstants.FullName);
            Assert.True(ut.TextPresentInElement(fullName).Displayed, "User's full mane is not displayed");
        }

            
       
    }


}
