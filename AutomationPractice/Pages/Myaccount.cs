using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Myaccount
    {
        readonly IWebDriver driver;

        public By signoutbtn = By.ClassName("logout");
        public By wishlists = By.ClassName("lnk_wishlist");
      

        public Myaccount(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("my-account")));

        }
    }
}
