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
        //IWebDriver driver = new ChromeDriver(@"c:\Program Files\Google\Chrome");


        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            //Create reference for browser
            PropertiesCollection.driver = new ChromeDriver(@"c:\Program Files\Google\Chrome");

            //Navigate to Google page
            //driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Thread.Sleep(2000);
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Select title
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            Thread.Sleep(2000);
            //Insert initial
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);
            Thread.Sleep(2000);

            Console.WriteLine("The value from my Title is : " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            Console.WriteLine("The value from my Title is : " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close URL");
        }
    }
}
