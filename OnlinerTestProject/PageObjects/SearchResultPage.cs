using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestProject.PageObjects
{
    public class SearchResultPage
    {
        [FindsBy(How = How.XPath, Using = "//iframe[@class='modal-iframe']")]
        private IWebElement ProductsFrame;

        [FindsBy(How = How.XPath, Using = "//li[.//a[text()='Ноутбук Apple MacBook Air 13\" 2020 MWTJ2']]")]
        private IWebElement Item;

        public void ClickItem()
        {
            WebDriverFactory.Driver.SwitchTo().Frame(ProductsFrame);

            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(Item));

            Item.Click();

            WebDriverFactory.Driver.SwitchTo().DefaultContent();
        }
    }
}