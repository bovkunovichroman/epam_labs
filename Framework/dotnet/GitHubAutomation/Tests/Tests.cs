using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using GitHubAutomation.Driver;
using GitHubAutomation.Service;
using GitHubAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Extensions;

namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class Tests : TestConfig
    {
        [Test]
        public void SignInToAccount()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                StartPage startPage = new StartPage(Driver)
                .ClickSignInAccountButton(Driver)
                .FillInLoginAndPassword(CreatingSignIn.WithUserProperties());
                AuthorizedPage authorizedPage = new AuthorizedPage(Driver);
                Assert.AreEqual("(Выйти)", authorizedPage.textSignInButton.Text);
            });
        }

        [Test]
        public void InputInvalidInputSityToWhenViewingSearchResultWithoutDateStatus()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                StartPage startPage = new StartPage(Driver)
               .GoToSearch(CreatingSearchResultWithoutDateModel.WithSearchResultWithoutDateProperties(),Driver);
                SearchRaceWithoutDatePage resultPage = new SearchRaceWithoutDatePage(Driver);
                Assert.AreEqual("Это поле необходимо заполнить", resultPage.errorMessage.Text);
            });           
        }
    }
}
