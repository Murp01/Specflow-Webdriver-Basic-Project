using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Webdriver_Training_Project_01.Selenium_Basics
{
    class PracticeExercise03
    {
        [Test]
        public void PracExercise03()
        {
            IWebDriver driver;

            driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");

            driver.FindElement(By.XPath("//a[contains(text(),'Selectable')]")).Click();

            driver.Navigate().Back();

            driver.Navigate().Forward();

            driver.Navigate().GoToUrl("https://demoqa.com/");

            driver.Navigate().Refresh();



        }

    }
}
