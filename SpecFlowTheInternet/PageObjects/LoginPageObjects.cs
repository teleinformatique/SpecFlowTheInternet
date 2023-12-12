using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTheInternet.PageObjects
{
    public sealed class LoginPageObjects : BasePageObjects
    {
        public LoginPageObjects(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameField => _driver.FindElement(By.Id("username"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
        public void EnterPassword(string password)
        {
            base.EnterText(password, PasswordField);
        }

        public void EnterUsername(string username)
        {
            base.EnterText(username, UsernameField);
        }

        public SecureAreaPageObjects SubmitForm()
        {
            base.ClickElement(SubmitButton);

            return new SecureAreaPageObjects(_driver);
        }
    }
}
