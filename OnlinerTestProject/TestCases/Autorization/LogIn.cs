using System.Configuration;
using NUnit.Framework;
using OnlinerTestProject.PageObjects;

namespace OnlinerTestProject.TestCases.Autorization
{
    public class LogIn : BaseTest
    {
        [Test]
        public void LogInAsUser()
        {
            Pages.HomePage.ClickSignInButton();
            Pages.LogInPage.EnterMail(ConfigurationManager.AppSettings["Email"]);
            Pages.LogInPage.EnterPassword(ConfigurationManager.AppSettings["Password"]);
            Pages.LogInPage.ClickLogInButton();

            Assert.IsTrue(Pages.HomePage.IsProfileLinkDisplayed());
        }
    }
}
