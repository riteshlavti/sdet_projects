using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FlipkartTest
{
    public class FlipkartSearchTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = DataClass.BASE_URI;
        }

        [TestCase("poco")]
        [TestCase("iphone")]
        public void SearchTest(string searchValue)
        {
            driver.FindElement(By.Name("q")).SendKeys(searchValue + Keys.Return);
            var list = driver.FindElements(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]/following-sibling::div"));
            
            for(int i=0;i<list.Count-2;i++)
            {
                Assert.IsTrue(list[i].Text.Contains(searchValue, StringComparison.CurrentCultureIgnoreCase));
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}