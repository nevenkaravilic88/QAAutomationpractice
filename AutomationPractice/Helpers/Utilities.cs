﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();
      //  private By search;

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ClickOnElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
        }

        internal void ClickOnElement(object searchBtn)
        {
            throw new NotImplementedException();
        }

        public void EnterTextElement(By selector, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);
        }

        public bool ElementDisplayed(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Displayed;
        }

        public string GeneraterandomEmail()
        {
            return string.Format("email{0}@nevenka.ravilic.com", RandomName.Next(100000, 1000000));
        }

     public void DropdownSelect(By select, string option)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(option);
        }

        internal void EnterTextElement(object searchFld, string term)
        {
            throw new NotImplementedException();
        }

        public IWebElement TextPresentInElement(string text)

        {
            By textElement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement));
        }

        public string ReturnTextFromElement(By selector)

        {
            return driver.FindElement(selector).GetAttribute("textContent");
    
        }

        public IList<IWebElement> ReturnCategoryList(string catName)
        {
            IList<IWebElement> category = driver.FindElements(By.CssSelector(".sf-menu [title='" + catName + "']"));
            return category;
        }
    }
}
