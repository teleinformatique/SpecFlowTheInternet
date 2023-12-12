using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTheInternet.PageObjects
{
    public class HomePageObjects: BasePageObjects
    {

        public const string baseUrl = "https://the-internet.herokuapp.com/";
       

        public HomePageObjects(IWebDriver driver):base(driver)
        {
         
        }

        public IWebElement WelcomeMessage => _driver.FindElement(By.CssSelector("h1.heading"));
        public IWebElement LoginLink => _driver.FindElement(By.XPath("//a[text()='Form Authentication']"));


        public void Load()
        {
            _driver.Url = baseUrl;
        }
        public string GetWelcomeMessage()
        {
            return WelcomeMessage.Text;
        }

        public LoginPageObjects ClickLink()
        {
            LoginLink.Click();

            return new LoginPageObjects(_driver);
        }



    }
}
