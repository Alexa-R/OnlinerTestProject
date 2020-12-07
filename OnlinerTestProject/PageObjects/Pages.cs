using OpenQA.Selenium.Support.PageObjects;

namespace OnlinerTestProject.PageObjects
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.Driver, page);
            return page;
        }

        public static HomePage HomePage => GetPage<HomePage>();

        public static LogInPage LogInPage => GetPage<LogInPage>();

        public static SearchResultPage SearchResultPage => GetPage<SearchResultPage>();

        public static ProductPage ProductPage => GetPage<ProductPage>();

        public static CartPage CartPage => GetPage<CartPage>();

        public static NewsPage NewsPage => GetPage<NewsPage>();
    }
}
