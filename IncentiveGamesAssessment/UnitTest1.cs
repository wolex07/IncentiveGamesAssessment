using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace IncentiveGamesAssessment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Creating a driver object
            IWebDriver driver = new ChromeDriver();

            // Navigating to url
            driver.Navigate().GoToUrl("https://incentivegames.com");

            // Maximizing window
            driver.Manage().Window.Maximize();

            // Clicking 'What We Do' link at the top of the page
            driver.FindElement(By.PartialLinkText("What We")).Click();

            // Close the window
            driver.Quit();
        }
    }
}
