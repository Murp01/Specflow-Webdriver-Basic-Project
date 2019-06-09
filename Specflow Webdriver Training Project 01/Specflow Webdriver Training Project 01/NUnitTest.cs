using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Webdriver_Training_Project_01
{
    class NUnitTest

    {
        IWebDriver driver;

        [SetUp]
        public void initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";          
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
