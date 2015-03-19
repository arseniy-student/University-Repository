using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Lib.Pages
{
    public class LoginPage:BaseObject
    {
        [FindsBy(How = How.Name, Using = USER_NAME_TEXT_FIELD)]
        public IWebElement userNameTextField;

        [FindsBy(How = How.Name, Using = PASSWORD_TEXT_FIELD)]
        public IWebElement passwordTextField;

        [FindsBy(How = How.Name, Using = LOGIN_BUTTON)]
        public IWebElement loginButton;
        
        [FindsBy(How = How.LinkText, Using = SIGN_IN_BUTTON)]
        public IWebElement SignInButton;

        public static LoginPage GetLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            InitPage(loginPage);
            return loginPage;
        }
        public LoginPage SignIn()
        {
            SignInButton.Click();
            return GetLoginPage();
        }

        public LoginPage TypeUserName(string userName)
        {
            userNameTextField.SendKeys(userName);
            return GetLoginPage();
        }

        public LoginPage TypePassword(string password)
        {
            passwordTextField.SendKeys(password);
            return GetLoginPage();
        }

        public CreateRepositoryPage ClickLoginButton()
        {
            loginButton.Click();
            return CreateRepositoryPage.GetCreateRepositoryPage();
        }

        public const string USER_NAME_TEXT_FIELD = "login";
        public const string PASSWORD_TEXT_FIELD = "password";
        public const string LOGIN_BUTTON = "commit";
        public const string SIGN_IN_BUTTON = "Sign in";


    }
}
