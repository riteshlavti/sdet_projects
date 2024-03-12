using OpenQA.Selenium;
using DataSet;
namespace TestProject
{
    [TestFixture]
    public class VerifyIndividualAmountTest : TestBase
    {
        [Test]
        public void VerifyIndividualAmount()
        {
            ResultPage resultPage = homePage.SearchProduct(TestData.TestSearchQuery);
            resultPage.SetPriceRange(TestData.DropDownMinPrice,TestData.DropDownMaxPrice);            
            resultPage.StoreAllVisibleProducts();
            List<string> addedProductListPrice = resultPage.GetAddedProductPriceList();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();
            cartPage.StoreAllCartProducts();

            for (int i = 0; i < cartPage.cartProductsList.Count; i++)
            {
                Assert.That(cartPage.FindElement(cartPage.cartProductsList[i], CartPage.ProductPriceXpath).Text,
                Is.EqualTo(addedProductListPrice[i]));
            }
        }
    }
}