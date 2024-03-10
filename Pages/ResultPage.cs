using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.FedCm;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FlipkartTest
{
    public class ResultPage
    {
        WebDriver webDriver;
        public IList<IWebElement> visibleElementsList;

        [FindsBy(How = How.XPath, Using = "//span[text()='Cart']")]
        private IWebElement _cartButton;

        [FindsBy(How = How.XPath, Using = "//option[text()='Min']//parent::select")]
        IWebElement _selectStartPrice;

        [FindsBy(How = How.XPath, Using = "//option[text()='₹30000+']//parent::select")]
        IWebElement _selectMaxPrice;
        SelectElement selectStartPrice;
        SelectElement selectMaxPrice;
        WebDriverWait wait;
        public ResultPage(WebDriver webDriver, WebDriverWait wait)
        {
            this.webDriver = webDriver;
            this.wait = wait;
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

        public void StoreAllVisibleElements()
        {
            visibleElementsList = webDriver.FindElements(By.XPath("//a[contains(@href,'oneplus-nord')]"));
        }

        public void ClickElement(IWebElement element)
        {
            Wrapper.ClickElement(element);
        }

        public string GetPrice(IWebElement element)
        {
            return element.FindElement(By.XPath("//div[1][contains(text(),'₹')]")).Text;
        }
        public void RefreshPage()
        {
            Wrapper.RefreshTab(webDriver);
        }

        public void SetPriceDropDown()
        {
            selectStartPrice = new SelectElement(_selectStartPrice);
            selectMaxPrice = new SelectElement(_selectMaxPrice);
        }

        public void ClickOnCart()
        {
            Wrapper.ClickElement(_cartButton);
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
    }
}