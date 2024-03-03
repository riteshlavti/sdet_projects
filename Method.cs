using OpenQA.Selenium;

namespace FlipkartTest2;

public class Method
{
    public void AddToCart(WebDriver driver,string query)
    {
        var handles = driver.WindowHandles;
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        driver.SwitchTo().Window(handles[0]);

        driver.FindElement(By.Name("q")).Click();
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript($"arguments[0].value = 'laptop';", driver.FindElement(By.Name("q")));
        driver.FindElement(By.Name("q")).SendKeys(Keys.Return);

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

        handles = driver.WindowHandles;
        driver.SwitchTo().Window(handles[1]);

        driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
        driver.Close();
    }
}
