using OpenQA.Selenium;

namespace TestWeb
{
    public class BasePage
    {
        private IWebDriver Driver { get; set; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        } 
    }
}