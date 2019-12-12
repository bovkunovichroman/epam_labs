using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
namespace PageObject
{
    public class StartPage
    {
        public StartPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#header > div > div > div > div.cabinet.right.js-cabinet > a.js-login.do-login > span")]
        private IWebElement signInButton;

        [FindsBy(How = How.CssSelector, Using = "#email_login")]
        private IWebElement MemberIdInput;

        [FindsBy(How = How.CssSelector, Using = "#pass_login")]
        private IWebElement PasswordInput;

        [FindsBy(How = How.CssSelector, Using = "#login_popup > div.popup__content > form > div.row.login-popup__footer > div > input")]
        private IWebElement EnterButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div/table[1]/tbody/tr[2]/td[2]/a")]
        private IWebElement plansPage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div[1]/div[1]/ul/li[1]/label")]
        private IWebElement RadioButtonOnlyTo;

        [FindsBy(How = How.Id, Using = "to_name")]
        private IWebElement TakePlaceTo;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[1]/div/input")]
        private IWebElement SearchButton;

        public StartPage ClickSignInAccountButton(IWebDriver webDriver)
        {
            signInButton.Click();
            return this;
        }

        public StartPage FillInLoginAndPassword(string login, string password)
        {
            MemberIdInput.SendKeys(login);          
            PasswordInput.SendKeys(password);
            EnterButton.Click();
            return this;
        }
      
        public StartPage GoToSearch(string town, IWebDriver webDriver)
        {
            RadioButtonOnlyTo.Click();
            TakePlaceTo.SendKeys(town);    
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);                          
            SearchButton.Click();
            SearchButton.Click();
            return this;
        }        
    }
}












//[FindsBy(How = How.Id, Using = "departure_date")]
//private IWebElement TakeDepartureDate;
//[FindsBy(How = How.CssSelector, Using = @"#ui-datepicker-div > div.ui-datepicker-group.ui-datepicker-group-first > table > tbody > tr:nth-child(4) > td.ui-datepicker-week-end.day_td.date_1576875600000")]
//[FindsBy(How = How.XPath, Using = @"//*[@id='ui - datepicker - div']/div[1]/table/tbody/tr[4]/td[6]/a")]
//[FindsBy(How = How.PartialLinkText, Using = "21")]




//TakeDepartureDate.Click();
//TakeDepartureDateCalendarChoice.Click();