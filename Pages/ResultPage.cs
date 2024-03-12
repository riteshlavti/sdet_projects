using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.FedCm;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class ResultPage : SeleniumWrapper
    {
        public IList<IWebElement> visibleProductsList;

        [FindsBy(How = How.XPath, Using = "//span[text()='Cart']")]
        private IWebElement _cartButton;

        [FindsBy(How = How.XPath, Using = "//option[text()='Min']//parent::select")]
        IWebElement _selectStartPrice;

        [FindsBy(How = How.XPath, Using = "//option[text()='₹30000+']//parent::select")]
        IWebElement _selectMaxPrice;

        [FindsBy(How = How.XPath,Using ="//span[contains(text(),'Clear all')]")]
        IWebElement _clearAll;
        SelectElement selectStartPrice;
        SelectElement selectMaxPrice;

        public ResultPage(WebDriver webDriver, WebDriverWait wait) : base(webDriver,wait)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public void SelectStartValue(string value)
        {
            selectStartPrice.SelectByValue(value);
        }

        public void SelectMaxValue(string value)
        {
            selectMaxPrice.SelectByValue(value);
        }

        public void StoreAllVisibleProducts()
        {
            IsClearAllVisible();
            visibleProductsList = webDriver.FindElements(By.XPath("//div[contains(text(),'Apple iPhone')]"));
        }

        public ProductPage ClickOnProduct(IWebElement element)
        {
            ClickElement(element);
            SwitchToWindow(1);
            return new ProductPage(webDriver,wait);
        }

        public string GetProductPrice(IWebElement element)
        {
            return FindElement(element,"//div[1][contains(text(),'₹')]").Text;
        }

        public void RefreshPage()
        {
            RefreshTab();
        }

        public void SetPriceDropDown()
        {
            selectStartPrice = new SelectElement(_selectStartPrice);
            selectMaxPrice = new SelectElement(_selectMaxPrice);
        }

        public CartPage ClickOnCart()
        {
            ClickElement(_cartButton);
            return new CartPage(webDriver);
        }

        public int PriceStringToInt(string input)
        {
            Match match = Regex.Match(input.Replace(",", "").Replace("₹",""), @"\d+");
            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            else
            {
                return 0;
            }
        }

        public bool IsClearAllVisible()
        {
            IsElementVisible(_clearAll);
            return true;
        }

        public void SetPriceRange(string minPrice,string maxPrice)
        {
            SetPriceDropDown();
            SelectStartValue(minPrice);
            SelectMaxValue(maxPrice);
        }

        public int CountProductsAdded()
        {
            int count =0;
            foreach (IWebElement element in visibleProductsList)
            {
                ProductPage productPage = ClickOnProduct(element);
                if (productPage.ClickOnAddToCart())
                {
                    count++;
                }
                productPage.CloseTab();
                productPage.SwitchToResultWindow();
            }
            return count;
        }

        public int GetTotalAmountOfProductsAdded()
        {
            int totalAmount =0;
            foreach (IWebElement element in visibleProductsList)
            {
                int price = PriceStringToInt(GetProductPrice(element));
                ProductPage productPage = ClickOnProduct(element);

                if (productPage.ClickOnAddToCart())
                {
                    totalAmount+=price;
                }
                productPage.CloseTab();
                productPage.SwitchToResultWindow();
            }
            return totalAmount;
        }

        public List<string> GetAddedProductPriceList()
        {
            List<string> addedProductListPrice = new List<string>();
            foreach (IWebElement element in visibleProductsList)
            {
                string price = GetProductPrice(element);
                ProductPage productPage = ClickOnProduct(element);
                if (productPage.ClickOnAddToCart())
                {
                    addedProductListPrice.Add(price);
                }
                productPage.CloseTab();
                productPage.SwitchToResultWindow();
            }
            return addedProductListPrice;
        }
    }
}