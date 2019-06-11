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
    class PracticeExercise05
    {
        IWebDriver driver;       

        //[Test]
        public void ClickVariousElementMethods()
        {
            driver = new FirefoxDriver();

            driver.Url = "http://toolsqa.com/automation-practice-form/";

            driver.FindElement(By.Name("firstname")).SendKeys("Alex");
            driver.FindElement(By.Name("lastname")).SendKeys("Murphy");
            driver.FindElement(By.Id("submit")).Click();
            driver.Quit();

        }

        [Test]
        public void ClickOnLinkWithPartialText()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://toolsqa.com/automation-practice-form/";

            driver.FindElement(By.PartialLinkText("Partial Li")).Click();
            String SubmitButtonTag = driver.FindElement(By.TagName("button")).ToString();
            Console.WriteLine(SubmitButtonTag);
            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("Link Test Pass");
            driver.Quit();

        }
    }
}
