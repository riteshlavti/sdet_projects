using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class DealOfTheDayPage : PageBase
    {
        By _dotdProductsOriginalPrice = By.XPath("//span[@class='grid-product__price--original']");
        By _dotdProductsDiscountedPrice = By.XPath("//span[@class='grid-product__price--savings']");
        By _dotdProductsDiscountPercentage = By.XPath("//span[@class='grid-product__price--savings']");
        public IList<IWebElement> originalPriceList;
        public IList<IWebElement> discountedPriceList;
        public IList<IWebElement> discountPercentageList;

        public DealOfTheDayPage(WebDriver webDriver, WebDriverWait wait) : base(webDriver, wait)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public void StoreProductsPriceDetails()
        {
            originalPriceList = FindElements(_dotdProductsOriginalPrice);
            discountedPriceList = FindElements(_dotdProductsDiscountedPrice);
            discountPercentageList=FindElements(_dotdProductsDiscountPercentage);
        }

        public int StringToInt(string input)
        {
            return int.Parse(input.Replace("Rs", "").Replace(",", "").Replace(".", "").Replace("%",""));
        }
    }
}