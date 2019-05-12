using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class FooterPage
    {
        readonly IWebDriver driver;
        public By footer = By.ClassName("footer - container");
       
        public FooterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("footer-container")));

        }
        public void ClickOnInformationLink(string title)
        {
            By link = By.CssSelector(".toggle-footer [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();
        }

        public bool InformationPageDisplayed(string page)

        {
            By InformationLink = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(InformationLink)).Displayed;

        }
         public bool MyaccountPageElementDisplayed(string page)

        {
            By MyaccountLink = By.XPath("//*[@class='navigation_page'][contains(text(),'" + page + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MyaccountLink)).Displayed;

        }
    }
}
