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
            //driver.Navigate().GoToUrl("http://www.google.com");
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Thread.Sleep(2000);
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Select title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            Thread.Sleep(2000);
            //Insert initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");
            Thread.Sleep(2000);

            Console.WriteLine("The value from my Title is : " + SeleniumGetMethods.GetText(driver, "TitleId","Id"));

            Console.WriteLine("The value from my Title is : " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            //click
            SeleniumSetMethods.Click(driver, "Save", "name");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Open URL");
        }
    }
}
