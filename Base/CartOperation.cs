using OpenQA.Selenium;

namespace FlipkartTest;

public class CartOperation : Base
{
    public int count=0;
    public void AddToCart()
    {
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
    }
}
