using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("http://bilet.aviakassa.by/");
        }

        [TearDown]
        public void QuitDriver()
        {
            webDriver.Quit();
        }

        [Test]
        public void SignInToAccount()
        {
            StartPage startPage = new StartPage(webDriver)
                .ClickSignInAccountButton(webDriver)
                .FillInLoginAndPassword("romantosik123@gmail.com", "1029384756");            
            AuthorizedPage authorizedPage = new AuthorizedPage(webDriver);
            Assert.AreEqual("(Выйти)", authorizedPage.textSignInButton.Text);
        }

        [Test]
        public void InputInvalidReservationCodeWhenViewingReservationStatus()
        {
            StartPage startPage = new StartPage(webDriver)
                .GoToSearch("Париж",webDriver);
     
            SearchRaceWithoutDate SearchResultPlane = new SearchRaceWithoutDate(webDriver);
            Assert.AreEqual("Это поле необходимо заполнить", SearchResultPlane.CorrectSearch.Text);
        }
    }
}
