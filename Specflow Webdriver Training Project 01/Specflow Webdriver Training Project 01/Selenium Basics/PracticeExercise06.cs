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
    class PracticeExercise06
    {
        IWebDriver driver;

        [Test]
        public void SelectRadioButton()
        {
            driver = new FirefoxDriver();

            driver.Url = "http://toolsqa.com/automation-practice-form/";

            IList<IWebElement> ORadioButton = driver.FindElements(By.Name("sex"));

            Boolean bValue = false;

            bValue = ORadioButton.ElementAt(0).Selected;

            if (bValue == true)
            {
                ORadioButton.ElementAt(0).Click();  
            }
            else
            {
                ORadioButton.ElementAt(1).Click();
            }

            driver.FindElement(By.Id("exp-2")).Click();

            IList<IWebElement> OCheckBox = driver.FindElements(By.Name("profession"));

            int Size = OCheckBox.Count();

            for (int i = 0; i < Size; i++)
            {
                String Value = OCheckBox.ElementAt(i).GetAttribute("value");
                if (Value == "Automation Tester")
                {
                    OCheckBox.ElementAt(i).Click();
                }

            }

            driver.FindElement(By.CssSelector("#tool-1")).Click();

        }

        

    }
}
