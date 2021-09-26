using OpenQA.Selenium;

namespace TestWeb
{
    public class ReactCrepe 
    {
        private IWebDriver Driver { get; }

        public bool IsVisible => Driver.FindElement(By.XPath("//header")).Text.Contains("React Examples");

        public ReactCrepe(IWebDriver driver)
        {
            Driver = driver;
        }


        public void Open()
        {
            Driver.Navigate().GoToUrl("https://react-crepe.pinkjelly.org/");
        }
    }
}