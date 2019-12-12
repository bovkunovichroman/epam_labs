using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    public class AuthorizedPage
    {
        public AuthorizedPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#header > div > div > div > div.cabinet.right.js-cabinet.logged_ico > a.js-logout.logout")]
        public IWebElement textSignInButton;
    }
}
