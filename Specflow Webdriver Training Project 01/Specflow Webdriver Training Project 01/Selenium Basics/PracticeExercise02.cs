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
    class PracticeExercise02
    {
        IWebDriver driver;

        [Test]
        public void PracticeExercise_02()
        {
            //1. Open Firefox driver
            driver = new FirefoxDriver();

            //2. Open webpage in browser
            driver.Url = "https://demoqa.com/";

            //3. Click on element on webpage
            driver.FindElement(By.XPath("//a[contains(text(),'Selectable')]")).Click();
           
            //4. Close browser - close as opposed to quit will close both windows
            driver.Close();
        }

    }
}
