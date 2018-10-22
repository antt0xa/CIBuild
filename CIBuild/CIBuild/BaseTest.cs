using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIBuild
{
    public class BaseTest
    {
        private IWebDriver _driver;

        [Test]
        public void FirstTest()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https:\\www.google.com");

            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@"D:\\TestResult\1.png");

            Assert.True(true);
        }

        [TearDown]
        public void tearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
