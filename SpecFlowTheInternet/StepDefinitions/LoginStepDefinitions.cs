using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTheInternet.Drivers;
using SpecFlowTheInternet.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTheInternet.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver _driver; 
        private HomePageObjects _homePage;
        private LoginPageObjects _loginPage;
        private SecureAreaPageObjects _secureAreaPage;

        public LoginStepDefinitions(BrowserDriver driver)
        {
            
            _homePage = _homePage = new(driver.Current);
        }

        [Given("i am on home page")]
        public void GivenIAmOnHomePage()
        {  
            _homePage.Load();
        }

        [When("i click on login link")]
        public void IClickOnLoginLink()
        {
            _loginPage =  _homePage.ClickLink();
        }

        [When("enter login (.*) with password (.*)")]
        public void WhenEnterLoginAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
            _secureAreaPage = _loginPage.SubmitForm();
        }

        [Then("the message (.*) is displayed")]
        public void TheSecureArreaIsDisplayed(string message)
        {
            string PageDescription = _secureAreaPage.GetPageDescription();
            PageDescription.Should().Be(message);
        }
    }
}
