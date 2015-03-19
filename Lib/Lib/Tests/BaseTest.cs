using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lib.Base;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium;

namespace Lib.Tests
{
    public class BaseTest : BaseObject
    {
        [TestFixtureSetUp]
        public void beforeClass()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var path = String.Format("{0}/{1}", System.IO.Path.GetDirectoryName(executingAssembly.Location), "chromedriver.exe");
            Environment.SetEnvironmentVariable("webdriver.chrome.driver", path);
            
            Driver = new ChromeDriver();
            Selenium = new WebDriverBackedSelenium(Driver, Utils.baseUrl);
            Selenium.Start();
            Selenium.WindowMaximize();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl(Utils.baseUrl);
        }

        [TestFixtureTearDown]
        public void afterClass()
        {
            Driver.Close();
            Selenium.Close();
        }
    }
}
