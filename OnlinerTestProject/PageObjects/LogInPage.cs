using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestProject.PageObjects
{
    public class LogInPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='auth-form__field']//input[@type='text']")]
        private IWebElement MailField;

        [FindsBy(How = How.XPath, Using = "//*[@type='password']")]
        private IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = "//*[@class='auth-form']//button[@type='submit']")]
        private IWebElement LogInButton;


        public void EnterMail(string mail)
        {
            MailField.SendKeys(mail);
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickLogInButton()
        {
            LogInButton.Click();
        }
    }
}
