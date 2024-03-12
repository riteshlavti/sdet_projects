using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture]
    public class VerifyIndividualAmountTest : TestBase
    {
        [Test]
        public void VerifyIndividualAmount()
        {
            ResultPage resultPage = homePage.SearchProduct(DataManager.SearchQuery);
            resultPage.SetPriceRange(DataManager.MinPrice,DataManager.MaxPrice);            
            resultPage.StoreAllVisibleElements();
            List<string> addedProductListPrice = resultPage.GetAddedProductPriceList();

            resultPage.RefreshPage();
            CartPage cartPage = resultPage.ClickOnCart();
            cartPage.StoreAllVisibleElements();

            for (int i = 0; i < cartPage.cartProductsList.Count; i++)
            {
                Assert.That(cartPage.FindElement(cartPage.cartProductsList[i], CartPage.ProductPriceXpath).Text,
                Is.EqualTo(addedProductListPrice[i]));
            }
        }
    }
}