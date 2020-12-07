using NUnit.Framework;
using OnlinerTestProject.PageObjects;

namespace OnlinerTestProject.TestCases.ShoppingCart
{
    public class AddItemToCart : BaseTest
    {
        [Test]
        public void AddViaProductPage()
        {
            Pages.HomePage.SearchItem("Ноутбук Apple MacBook Air 13 2020 MWTJ2");
            Pages.SearchResultPage.ClickItem();
            Pages.ProductPage.ClickAddToCartButton();
            Pages.ProductPage.OpenCartPage();

            Assert.AreEqual("Оформить заказ", Pages.CartPage.GetCheckoutButtonText());
        }
    }
}
