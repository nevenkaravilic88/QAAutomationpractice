using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class CreateAnAccountPage
    {
        readonly IWebDriver driver;

        public By createanaccount = By.Id("");
        public By firstname = By.Id("customer_firstname");
        public By lastname = By.Id("customer_lastname");
       // public By email 


        public CreateAnAccountPage(IWebDriver driver)
        {

          this.driver = driver;
          var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
          wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));

        }
    }
}
