using System.Configuration;
using NUnit.Framework;
namespace OnlinerTestProject.TestCases
{
    [TestFixture]
    public class BaseTest
    {

        [SetUp]
        public void SetUpTest()
        {
            WebDriverFactory.InitBrowser("Chrome");
            WebDriverFactory.GoToUrl(ConfigurationManager.AppSettings["URL"]);
            WebDriverFactory.Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownTest()
        {
            WebDriverFactory.CloseAllDrivers();
        }
    }
}
