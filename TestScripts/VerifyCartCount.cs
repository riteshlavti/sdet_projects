using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;
using DataSet;
namespace TestProject
{
    [TestFixture]
    public class VerifyCartCountTest : TestBase
    {
        [Test]
        public void VerifyCartCount()
        {
            ResultPage resultPage = homePage.SearchProduct(TestData.TestSearchQuery);
            resultPage.SetPriceRange(TestData.DropDownMinPrice,TestData.DropDownMaxPrice);            
            resultPage.StoreAllVisibleProducts();
            int count = resultPage.CountProductsAdded();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();
            cartPage.StoreAllCartProducts();
            
            Assert.That(cartPage.cartProductsList.Count,Is.EqualTo(count));
        }
    }
}