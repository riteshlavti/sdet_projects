using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class HomePage : SeleniumWrapper
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchBar; 

        public HomePage(WebDriver webDriver, WebDriverWait wait) : base(webDriver,wait)
        {
            PageFactory.InitElements(webDriver,this);
        }

        public HomePage LoadUrl()
        {
            webDriver.Url = "https://www.flipkart.com";
            return new HomePage(webDriver,wait);
        }

        public void ClickOnSearchBar()
        {
            ClickElement(_searchBar);
        }

        public void SendInputToSearchBar(string input)
        {
            SendInput(_searchBar,input);
        }

        public ResultPage SendEnterKeyToSearchBar()
        {
            SendEnterKey(_searchBar);
            return new ResultPage(webDriver,wait);
        }

        public ResultPage SearchProduct(string input)
        {
            ClickOnSearchBar();
            SendInputToSearchBar(input);
            return SendEnterKeyToSearchBar();
        }
    }
}