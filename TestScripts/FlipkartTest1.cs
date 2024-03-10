using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;

namespace FlipkartTest
{
    [TestFixture]
    public class FlipkartTest1 : Base
    {
        [Test]
        public void VerifyCartCount()
        {
            int count=0;
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
                    count++;
                }
                objCartPage.CloseTab();
                objCartPage.SwitchToResultWindow();
            }

            objResultPage.RefreshPage();
            objResultPage.ClickOnCart();
            objCartPage.StoreAllVisibleElements();
            
            Assert.That(objCartPage.cartProductsList.Count,Is.EqualTo(count));
        }
    }
}