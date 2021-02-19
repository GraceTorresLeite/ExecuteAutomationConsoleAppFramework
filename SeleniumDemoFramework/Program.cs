using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create reference for browser
            IWebDriver driver = new ChromeDriver(@"c:\Program Files\Google\Chrome");

            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform 
            element.SendKeys("executeautomation");
        }
    }
}
