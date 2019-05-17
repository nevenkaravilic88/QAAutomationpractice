﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Homepage
    {
        readonly IWebDriver driver;

        public By signIn = By.ClassName("login");
        public By searchFld = By.Id("search_query_top");
        public By searchBtn = By.ClassName("button-search");
        public By dresses = By.CssSelector(".sf-menu [title='Dresses']");
        public By contactUs = By.Id("contact-link");

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("index")));
        }

       
    }
}
