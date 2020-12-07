using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestProject.PageObjects
{
    public class NewsPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-reaction='slight_smile']//span[@class='st-count']")]
        private IWebElement LikeCount;

        public string GetLikeCountText()
        {
            return LikeCount.Text;
        }
    }
}
