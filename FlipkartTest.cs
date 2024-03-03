using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.IndexedDB;

namespace FlipkartTest
{
    public class FlipkartTest
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Url = DataClass.BASE_URI;
        }

        [TestCase("poco")]
        [TestCase("iphone")]
        public void Test(string searchValue)
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