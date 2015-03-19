using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using Selenium;
namespace Lib.Base
{
    public class BaseObject
    {
        public static RemoteWebDriver Driver;
        public static DefaultSelenium Selenium;

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(Driver, pageClass);
        }
    }
}
