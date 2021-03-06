﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lib.Base;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Selenium;

namespace Lib.Tests
{
    public class BaseTest : BaseObject
    {
        [TestFixtureSetUp]
        public void beforeClass()
        {
            Logger.Setup();
            const string path = @"c:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            Driver = new FirefoxDriver(new FirefoxBinary(path), new FirefoxProfile());
            Selenium = new WebDriverBackedSelenium(Driver, Utils.baseUrl);
            Selenium.Start();
            Selenium.WindowMaximize();
            log.Info("beforeClass() complete");
        }

        [SetUp]
        public void beforeTest()
        {

            log.Info("beforeTest() complete");
            Driver.Navigate().GoToUrl(Utils.baseUrl);
        }

        [TestFixtureTearDown]
        public void afterClass()
        {
            log.Info("afterClass() complete");
            Driver.Close();
            Selenium.Close();//exception
        }
    }
}
