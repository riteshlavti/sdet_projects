using OpenQA.Selenium;

namespace FlipkartTest
{
    [TestFixture]
    public class FlipkartTest2 : Base
    {
        [Test]
        public void VerifyTotalAmount()
        {
            int sum = 0;
            objHomePage.ClickOnSearchBar();
            objHomePage.SendInputToSearchBar("one plus nord");
            objHomePage.SendEnterKeyToSearchBar();

            objResultPage.SetPriceDropDown();
            objResultPage.SelectStartValue("Min");
            objResultPage.SelectMaxValue("30000");
            objResultPage.StoreAllVisibleElements();

            foreach (IWebElement element in objResultPage.visibleElementsList)
            {
                int price = objResultPage.PriceStringToInt(objResultPage.GetPrice(element));
                objResultPage.ClickElement(element);
                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
                if (objProductPage.ClickOnAddToCart())
                {
                    sum += price;
                }
                objCartPage.CloseTab();
                objCartPage.SwitchToResultWindow();
            }

            objResultPage.RefreshPage();
            objResultPage.ClickOnCart();

            int totalAmount = objResultPage.PriceStringToInt(objCartPage.ReturnsPrice());
            Assert.That(sum, Is.EqualTo(totalAmount));
        }
    }
}