using OpenQA.Selenium;

namespace SpecFlowTheInternet.PageObjects
{
    public class SecureAreaPageObjects: BasePageObjects
    {
        public SecureAreaPageObjects(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement PageDescription => _driver.FindElement(By.CssSelector("h4.subheader"));

        public string GetPageDescription()
        {
            return PageDescription.Text;
        }
    }
}