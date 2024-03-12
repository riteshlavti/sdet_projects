using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture]
    public class VerifyCartCountTest : TestBase
    {
        [Test]
        public void VerifyCartCount()
        {
            ResultPage resultPage = homePage.SearchProduct(DataManager.SearchQuery);
            resultPage.SetPriceRange(DataManager.MinPrice,DataManager.MaxPrice);            
            resultPage.StoreAllVisibleElements();
            int count = resultPage.CountProductsAdded();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();
            cartPage.StoreAllVisibleElements();
            
            Assert.That(cartPage.cartProductsList.Count,Is.EqualTo(count));
        }
    }
}