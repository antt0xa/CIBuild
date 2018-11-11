using Allure.Commons;
using Allure.NUnit.Attributes;
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
    [AllureSuite("HomePage Tests")]
    [AllureEpic("Epic story")]
    public class BaseTest : AllureReport
    {
        protected static string AllureConfigDir { get; } = @"C:\Program Files\Jenkins\workspace\OctoberLearn\allure-results";

        private IWebDriver _driver;

        [Test]
        public void FirstTest()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https:\\www.google.com");

            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@"D:\\TestResult\1.png");

            Assert.True(true);
        }

        [Test]
        public void SecondTest()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https:\\www.google.com");

            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@"D:\\TestResult\2.png");

            Assert.True(true);
        }

        [Test]
        public void ThirdTest()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https:\\www.google.com");

            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@"D:\\TestResult\2.png");

            Assert.True(true);
        }

        [Test]
        public void Fourth()
        {
            _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https:\\www.google.com");

            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@"D:\\TestResult\2.png");

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
