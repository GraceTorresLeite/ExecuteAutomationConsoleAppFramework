using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoFramework
{
    //https://www.youtube.com/watch?v=uCulwN3tRuM&list=PL6tu16kXT9PqKSouJUV6sRVgmcKs-VCqo&index=6
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                return driver.FindElement(By.Id(element)).Text;
            if (elementType == "Name")
                return driver.FindElement(By.Name(element)).Text;
            else return String.Empty;
        }
    }
}
