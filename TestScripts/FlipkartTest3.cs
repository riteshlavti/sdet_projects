using OpenQA.Selenium;

namespace FlipkartTest
{
    [TestFixture]
    public class FlipkartTest3 : Base
    {
        [Test]
        public void VerifyIndividualAmount()
        {
            List<IWebElement> addedProductList = new List<IWebElement>();
            objHomePage.ClickOnSearchBar();
            objHomePage.SendInputToSearchBar("one plus nord");
            objHomePage.SendEnterKeyToSearchBar();

            objResultPage.SetPriceDropDown();
            objResultPage.SelectStartValue("Min");
            objResultPage.SelectMaxValue("30000");
            objResultPage.StoreAllVisibleElements();

            foreach (IWebElement element in objResultPage.visibleElementsList)
            {
                objResultPage.ClickElement(element);
                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
                if (objProductPage.ClickOnAddToCart())
                {
                    addedProductList.Add(element);
                }
                objCartPage.CloseTab();
                objCartPage.SwitchToResultWindow();
            }

            objResultPage.RefreshPage();
            objResultPage.ClickOnCart();
            objCartPage.StoreAllVisibleElements();

            for (int i = 0; i < objCartPage.cartProductsList.Count; i++)
            {
                Assert.That(Wrapper.FindElement(objCartPage.cartProductsList[i], "//span[2][contains(text(),'₹')]").Text,
                Is.EqualTo(Wrapper.FindElement(addedProductList[i], "//div[1][contains(text(),'₹')]").Text));
            }
        }
    }
}