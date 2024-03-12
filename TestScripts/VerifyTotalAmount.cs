using OpenQA.Selenium;
using DataSet;
namespace TestProject
{
    [TestFixture]
    public class VerifyTotalAmountTest : TestBase
    {
        [Test]
        public void VerifyTotalAmount()
        {
            ResultPage resultPage = homePage.SearchProduct(TestData.TestSearchQuery);
            resultPage.SetPriceRange(TestData.DropDownMinPrice,TestData.DropDownMaxPrice);            
            resultPage.StoreAllVisibleProducts();
            int totalAmount = resultPage.GetTotalAmountOfProductsAdded();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();

            int totalAmountOnCart = resultPage.PriceStringToInt(cartPage.GetPrice());
            Assert.That(totalAmount, Is.EqualTo(totalAmountOnCart));
        }
    }
}