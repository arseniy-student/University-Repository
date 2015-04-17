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
    public class CreateRepositoryPage:BaseObject
    {

        [FindsBy(How = How.LinkText, Using = NEW_REPOSITORY_BUTTON)]
        public IWebElement NewRepositoryButton;

        [FindsBy(How = How.Id, Using = REPOSITORY_NAME_INPUT)]
        public IWebElement RepositoryNameInput;

        [FindsBy(How = How.XPath, Using = CREATE_REPOSITORY_BUTTON)]
        public IWebElement CreateRepositoryButton;
        public static CreateRepositoryPage GetCreateRepositoryPage()
        {
            CreateRepositoryPage repositoryPage = new CreateRepositoryPage();
            InitPage(repositoryPage);
            return repositoryPage;
        }

        public CreateRepositoryPage ClickNewRepositoryButton()
        {
            NewRepositoryButton.Click();
            return GetCreateRepositoryPage();
        }

        public CreateRepositoryPage TypeRepositoryName(string name)
        {
            RepositoryNameInput.SendKeys(name);
            return GetCreateRepositoryPage();
        }

        public CreateRepositoryPage CreateNewRepository()
        {
            CreateRepositoryButton.Click();
            return GetCreateRepositoryPage();
        }

        public const string NEW_REPOSITORY_BUTTON = "New repository";
        public const string REPOSITORY_NAME_INPUT = "repository_name";
        public const string CREATE_REPOSITORY_BUTTON = "//button[@type=\"submit\"]";
    }
}
