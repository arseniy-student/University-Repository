using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Lib
{
    public class TestClass
    {
        public static void Test()
        {
            IWebDriver myWebDriver = new ChromeDriver();
            myWebDriver.Manage().Window.Maximize();

            myWebDriver.Navigate().GoToUrl("https://github.com/");
            
            myWebDriver.FindElement(By.LinkText("Sign in")).Click();

            myWebDriver.FindElement(By.Name("login")).SendKeys("arseniy-student");
            myWebDriver.FindElement(By.Name("password")).SendKeys("arseniy93");
            myWebDriver.FindElement(By.Name("commit")).Click();

            myWebDriver.FindElement(By.LinkText("New repository")).Click();
            myWebDriver.FindElement(By.Id("repository_name")).SendKeys("MyDirectory");

            myWebDriver.FindElement(By.XPath("//*[@class='button primary first-in-line']")).Click();
            
        }
    }
}
