using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTheInternet.PageObjects
{
    public class BasePageObjects
    {
        protected IWebDriver _driver;

        public BasePageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetPageTitle()
        {
            return _driver.Title;
        }

        public void EnterText(string value, IWebElement locator)
        {
            locator.Clear();
            locator.SendKeys(value);
        }

        public void ClickElement(IWebElement locator)
        {
            locator.Click();
        }

    }
}
