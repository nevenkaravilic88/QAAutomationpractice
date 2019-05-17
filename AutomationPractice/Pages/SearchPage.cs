﻿using AutomationPractice.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class SearchPage
    {
        readonly IWebDriver driver;

        public By searchTerm = By.ClassName("lighter");
        public By firstProduct = By.CssSelector(".product_img_link .replace-2x");

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("search")));
        }
    }
}
