using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        FooterPage fp = new FooterPage(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {

            fp.ClickOnInformationLink(link);
        }
        
        [Then(@"'(.*)' is displayed")]
        public void ThenIsDisplayed(string page)
        {

         
            Assert.True(fp.InformationPageDisplayed(page), "Coreect page is not displayed");

        }

        [When(@"user clicks on '(.*)' option under Myaccount section")]
        public void WhenUserClicksOnOptionUnderMyaccountSection(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"correct '(.*)'under Myaccount is displayed")]
        public void ThenCorrectUnderMyaccountIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }

}
