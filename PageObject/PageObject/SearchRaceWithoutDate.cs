using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObject
{
    class SearchRaceWithoutDate
    {
        public SearchRaceWithoutDate(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#base_direction > div > div.fields_block > div.form-item.form-item--date.input-block.search_field.date_field > div > samp")]
        public IWebElement CorrectSearch;
    }
}
