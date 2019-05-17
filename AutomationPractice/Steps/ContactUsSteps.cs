using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {

        Utilities ut = new Utilities(Driver);

        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            Homepage hp = new Homepage (Driver);
            ut.ClickOnElement(hp.contactUs);
        }

        [Given(@"fills in all required fields with '(.*)' heading and '(.*)' message")]
        public void GivenFillsInAllRequiredFieldsWithHeadingAndMessage(string heading, string message)
        {
            Utilities ut = new Utilities(Driver);
            ContactUpPage cup = new ContactUpPage(Driver);
            ut.DropdownSelect(cup.subjectHeading, heading);
            ut.EnterTextElement(cup.contactEmail, ut.GeneraterandomEmail());
            ut.EnterTextElement(cup.message, message);
        }

        [When(@"user submits the form")]
        public void WhenUserSubmitsTheForm()
        {
            Utilities ut = new Utilities(Driver);
            ContactUpPage cup = new ContactUpPage(Driver);
            ut.ClickOnElement(cup.sendBtn);

        }

        [Then(@"message '(.*)' is presented to the user")]
        public void ThenMessageIsPresentedToTheUser(string alertMsg)
        {
            Utilities ut = new Utilities(Driver);
            ContactUpPage cup = new ContactUpPage(Driver);
            Assert.That(ut.ReturnTextFromElement(cup.successMessage), Is.EqualTo(alertMsg), "Message was not sent to customer service");

        }

    }
}
