using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Base;
using Lib.Pages;

namespace Lib.TestHelpers
{
    public class Helper
    {
        private LoginPage loginPage = new LoginPage();
        private CreateRepositoryPage createRepositoryPage = new CreateRepositoryPage();

        public Helper DoLogin(string username, string password)
        {
            BaseObject.InitPage(loginPage);
            loginPage.SignIn().TypeUserName(username).TypePassword(password).ClickLoginButton();
            return this;
        }

        public Helper CreateRepository(string repositoryName)
        {
            BaseObject.InitPage(createRepositoryPage);
            createRepositoryPage.ClickNewRepositoryButton().TypeRepositoryName(repositoryName).CreateNewRepository();
            return this;
        }
    }
}
