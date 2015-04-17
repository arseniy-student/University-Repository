using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using Selenium;
namespace Lib.Base
{
    public class BaseObject
    {
        public static RemoteWebDriver Driver;
        public static DefaultSelenium Selenium;
        public static readonly ILog log = LogManager.GetLogger(typeof(BaseObject)); 
        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            Selenium.WindowMaximize();
            PageFactory.InitElements(Driver, pageClass);
        }
    }
}
