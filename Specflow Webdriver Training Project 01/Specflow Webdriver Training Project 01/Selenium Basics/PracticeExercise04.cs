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
    class PracticeExercise04
    {

        IWebDriver driver;

        [Test]
        public void WebElementClick()
        {           
            driver = new FirefoxDriver();
            driver.Url = "https://www.toolsqa.com/Automation-practice-form/";

            IWebElement InputBox_FirstName = driver.FindElement(By.XPath("//input[contains(@name,'firstname')]"));
            IWebElement Button_Submit = driver.FindElement(By.XPath("//button[@id='submit']"));

            InputBox_FirstName.SendKeys("Paul");
            Button_Submit.Click();
        }


    }
}
