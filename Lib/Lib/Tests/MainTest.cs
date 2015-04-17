using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.TestHelpers;
using NUnit.Framework;

namespace Lib.Tests
{
    [TestFixture]
    public class MainTest:BaseTest
    {
        private static Helper helper = new Helper();

        [Test]
        public static void CreateRepository()
        {
            string username = "arseniy-student";
            string password = "arseniy93";
            string repositoryName = "MyDirectory";

            helper.DoLogin(username, password).CreateRepository(repositoryName);
        }
    }
}
