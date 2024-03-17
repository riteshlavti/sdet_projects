using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class PrintedTees : PageBase
    {
        [FindsBy(How =How.CssSelector,Using ="select[id='SortBy']")]
        IWebElement _filterDropDown;
        [FindsBy(How =How.XPath,Using ="//span[text()='Previous']")]
        IWebElement _previousBtn;
        [FindsBy(How =How.XPath,Using ="//span[text()='Next']")]
        IWebElement _nextBtn;
        By _next = By.XPath("a[title='Next']");
        By _previous = By.XPath("a[title='Previous']");
        string alphabeticallyZtoAOption = "title-descending";
        By _visibleFilterValue = By.XPath("//option[contains(text(),'Sort') and @value='title-ascending']");
        By _product = By.CssSelector("div[class='grid-product__content']");
        By _productTitle = By.CssSelector("div[class='grid-product__title grid-product__title--heading']");

        SelectElement selectFilter;
  
        public PrintedTees(WebDriver webDriver,WebDriverWait wait) : base(webDriver,wait)
        {
            PageFactory.InitElements(webDriver,this);
        }

        public void SetFilter()
        {
            selectFilter = new SelectElement(_filterDropDown);
            selectFilter.SelectByValue(alphabeticallyZtoAOption);
        }

        public void IsFilterValueVisible()
        {
            IsElementVisible(_visibleFilterValue);
        }

        public ProductPage SelectProductWithId(int id)
        {
            ClickElement(FindElement($"//div[contains(text(),'TEE#{id}')]"));
            return new ProductPage(webDriver,wait);
        }

        public IList<IWebElement> GetProductsList()
        {
            return FindElements(_productTitle);
        }
    }
}