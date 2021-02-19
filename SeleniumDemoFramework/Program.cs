using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemoFramework
{
    class Program
    {

        //Create reference for browser
        IWebDriver driver = new ChromeDriver(@"c:\Program Files\Google\Chrome");


        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(2000);
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform 
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute test");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Open URL");
        }
    }
}
