using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest
{
    public class Base
    {
        public WebDriver webDriver;
        public static WebDriverWait wait;
        public HomePage objHomePage;
        public ResultPage objResultPage;
        public CartPage objCartPage;
        public ProductPage objProductPage;

        [SetUp]
        public void SetupDriverAndPageObject()
        {
            webDriver = new ChromeDriver();
            webDriver.Url = "https://www.flipkart.com";
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objHomePage = new HomePage(webDriver);
            objCartPage = new CartPage(webDriver, wait);
            objProductPage = new ProductPage(webDriver, wait);
            objResultPage = new ResultPage(webDriver, wait);
            webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownWebDriver()
        {
            webDriver.Quit();
        }
    }
}