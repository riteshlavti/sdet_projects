using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture]
    public class VerifyTotalAmountTest : TestBase
    {
        [Test]
        public void VerifyTotalAmount()
        {
            ResultPage resultPage = homePage.SearchProduct(DataManager.SearchQuery);
            resultPage.SetPriceRange(DataManager.MinPrice,DataManager.MaxPrice);            
            resultPage.StoreAllVisibleElements();
            int totalAmount = resultPage.GetTotalAmountOfProductsAdded();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();

            int totalAmountOnCart = resultPage.PriceStringToInt(cartPage.GetPrice());
            Assert.That(totalAmount, Is.EqualTo(totalAmountOnCart));
        }
    }
}