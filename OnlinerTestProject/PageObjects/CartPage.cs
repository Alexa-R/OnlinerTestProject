using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestProject.PageObjects
{
    public class CartPage
    {
        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'confirm')]")]
        private IWebElement CheckoutButton;

        public string GetCheckoutButtonText()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(CheckoutButton));

            return CheckoutButton.Text;
        }
    }
}
