using AutomationPractice.Helpers;
using AutomationPractice.Pages;
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
        public void ThenIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
