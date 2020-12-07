using NUnit.Framework;
using OnlinerTestProject.PageObjects;

namespace OnlinerTestProject.TestCases.NewsCard
{
    public class CheckLikesOnNews : BaseTest
    {
        [Test]
        public void CountLikesOnNews()
        {
            Pages.HomePage.ScrollToTech();
            Pages.HomePage.ClickLastNews();

            Assert.True(int.Parse(Pages.NewsPage.GetLikeCountText()) >= 0);
        }
    }
}
