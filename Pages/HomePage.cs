using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FlipkartTest
{
    public class HomePage
    {
        private WebDriver webDriver;

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchBar; 

        public HomePage(WebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver,this);
        }

        public void ClickOnSearchBar()
        {
            Wrapper.ClickElement(_searchBar);
        }

        public void SendInputToSearchBar(string input)
        {
            Wrapper.SendInput(_searchBar,input);
        }

        public void SendEnterKeyToSearchBar()
        {
            Wrapper.SendEnterKey(_searchBar);
        }
    }
}