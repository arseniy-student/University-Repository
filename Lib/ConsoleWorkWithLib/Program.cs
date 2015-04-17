using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lib;
using Lib.Base;
using Lib.Tests;

namespace ConsoleWorkWithLib
{

    class Program
    {
        static void Main(string[] args)
        {
            var ass = Assembly.GetExecutingAssembly();
            var path = String.Format("{0}/{1}",System.IO.Path.GetDirectoryName(ass.Location),"chromedriver.exe");
            Environment.SetEnvironmentVariable("webdriver.chrome.driver", path);
            MainTest.CreateRepository();
        }
    }
}
