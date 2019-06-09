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
    class PracticeExcercise01
    {
        [Test]
        public void PracticeExercise01()
        {
            IWebDriver driver;
            //1. Launch FireFox Driver
            driver = new FirefoxDriver();

            //2. Launch demoqa.com
            driver.Url = "http://www.demoqa.com";

            //3. Get page title name & length
            String Title = driver.Title;
            int TitleLength = driver.Title.Length;

            //4. Print title and length to console (click output in NUnit test results
            Console.WriteLine("Title of the page is : " + Title);
            Console.WriteLine("The title length is : " + TitleLength);

            //5. Get Page URL and Page URL length
            String UrlTitle = driver.Url;
            int UrlLength = driver.Url.Length;

            //6. Print URL and URL length to console
            Console.WriteLine("URL of the page is : " + UrlTitle);
            Console.WriteLine("The url length is : " + UrlLength);

            //7. Get Page Source and page source length
            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;

            //8. Print page source length to console
            Console.WriteLine("The page source length is : " + PageSourceLength);


        }
    }
}
