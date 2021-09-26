using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWeb
{
    [TestClass]
    public class TestWeb
    {
        private IWebDriver Driver { get; set; }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
        [TestMethod]
        public void TestCatComeAgain()
        {
            Driver = GetChromeDriver();
            Driver.Manage().Window.Maximize();
            var reactCrepe = new ReactCrepe(Driver);
            reactCrepe.Open();
            Assert.IsTrue(reactCrepe.IsVisible);

        }
    }
}