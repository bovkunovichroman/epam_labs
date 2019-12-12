using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using GitHubAutomation.Model;
using GitHubAutomation.Service;
using GitHubAutomation.Driver;

namespace GitHubAutomation.Pages
{
    class SearchRaceWithoutDatePage
    {
        public SearchRaceWithoutDatePage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#base_direction > div > div.fields_block > div.form-item.form-item--date.input-block.search_field.date_field > div > samp")]
        public IWebElement errorMessage;
    }
}
