using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class CartPage : SeleniumWrapper
    {
        WebDriver webDriver;
        public IList<IWebElement> cartProductsList;

        [FindsBy(How = How.XPath, Using = "//div[text()='Total Amount']//parent::div//following-sibling::div")]
        IWebElement _totalPriceValue;
        public const string ProductPriceXpath = "//div[contains(@class,'col-12-12')]/div/div/div/span[contains(text(),'₹')][last()]";

        public CartPage(WebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public string GetPrice()
        {
            return _totalPriceValue.Text;
        }

        public void StoreAllVisibleElements()
        {
            cartProductsList = webDriver.FindElements(By.XPath("//a[contains(text(),'Apple')]"));
        }
    }
}