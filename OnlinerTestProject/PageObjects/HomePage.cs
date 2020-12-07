using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace OnlinerTestProject.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='userbar']//div[text()='Вход']")]
        private IWebElement SignInButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'profile__preview')]")]
        private IWebElement ProfileLink;

        [FindsBy(How = How.XPath, Using = "//*[@class='fast-search__input']")]
        private IWebElement SearchField;

        [FindsBy(How = How.XPath, Using = "//h2//*[text()='Технологии']")]
        private IWebElement TechSection;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'main-page-news')][./header//*[text()='Технологии']]/div//li[last()]")]
        private IWebElement LastNews;


        public void ClickSignInButton()
        {
            SignInButton.Click();
        }

        public bool IsProfileLinkDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(WebDriverFactory.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(ProfileLink));

            return ProfileLink.Displayed;
        }

        public void SearchItem(string item)
        {
            SearchField.SendKeys(item);
        }

        public void ScrollToTech()
        {
            Actions builder = new Actions(WebDriverFactory.Driver);
            builder.MoveToElement(TechSection).Build().Perform();
        }

        public void ClickLastNews()
        {
            LastNews.Click();
        }
    }
}
