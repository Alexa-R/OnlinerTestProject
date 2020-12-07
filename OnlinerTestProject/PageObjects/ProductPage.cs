using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestProject.PageObjects
{
    public class ProductPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='product-aside__box']/a[contains(@class,'item-button')]")]
        private IWebElement AddToCartButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='userbar']//*[@title='Корзина']")]
        private IWebElement Cart;

        public void ClickAddToCartButton()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToCartButton));

            AddToCartButton.Click();
        }

        public void OpenCartPage()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(AddToCartButton));

            Cart.Click();
        }
    }
}
