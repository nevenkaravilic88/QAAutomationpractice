using System;
using OpenQA.Selenium;

namespace AutomationPractice.Helpers
{
    internal class SelectElement
    {
        private IWebElement dropdown;

        public SelectElement(IWebElement dropdown)
        {
            this.dropdown = dropdown;
        }

        internal void SelectByText(string option)
        {
            throw new NotImplementedException();
        }
    }
}