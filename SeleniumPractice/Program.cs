using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using System.ComponentModel;
using OpenQA.Selenium.Support.UI;

IWebDriver driver = new ChromeDriver();

driver.Url = "https://www.flipkart.com";
// driver.FindElement(By.Name("q")).Click();
// // driver.FindElement(By.Name("q")).SendKeys("webdriver" + Keys.Return);
// Console.WriteLine(driver.Title);
// driver.Close();
// driver.FindElement(By.Name("q")).SendKeys("poco" + Keys.Return);
// var list = driver.FindElements(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]/following-sibling::div"));

// for (int i=0;i<list.Count-2;i++)
// {
//     Console.WriteLine("in loop");
//     Console.WriteLine(list[i].Text);
// }

//driver.FindElement(By.XPath("/html/body/div[3]/div/span")).Click();
//driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
driver.Manage().Window.Maximize();

//product-1
driver.FindElement(By.Name("q")).SendKeys("poco" + Keys.Return);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

var handles = driver.WindowHandles;
driver.SwitchTo().Window(handles[1]);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
driver.Close();

//product-2
driver.SwitchTo().Window(handles[0]);

driver.FindElement(By.Name("q")).Click();

IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
js.ExecuteScript("arguments[0].value = 'Fridge';", driver.FindElement(By.Name("q")));
driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

handles = driver.WindowHandles;
driver.SwitchTo().Window(handles[1]);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
driver.Close();

//product-3
handles = driver.WindowHandles;
driver.SwitchTo().Window(handles[0]);

driver.FindElement(By.Name("q")).Click();
js.ExecuteScript("arguments[0].value = 'laptop';", driver.FindElement(By.Name("q")));
driver.FindElement(By.Name("q")).SendKeys(Keys.Return);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

handles = driver.WindowHandles;
driver.SwitchTo().Window(handles[1]);

driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
driver.Close();

//product-4
// driver.SwitchTo().Window(handles[0]);
// driver.FindElement(By.Name("q")).Click();
// js.ExecuteScript("arguments[0].value = 'juicer';", driver.FindElement(By.Name("q")));
// driver.FindElement(By.Name("q")).SendKeys(Keys.Return);

// driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

// handles = driver.WindowHandles;
// driver.SwitchTo().Window(handles[1]);

// driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
// driver.Close();
driver.SwitchTo().Window(handles[0]);
driver.Navigate().Refresh();
//driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
driver.FindElement(By.XPath("//*[@id='container']/div/div[1]/div[1]/div[2]/div[6]/div/div/a")).Click();
int count = driver.FindElements(By.XPath("//*[@id='container']/div/div[2]/div/div/div[1]/div/div[2]/following-sibling::div")).Count();
Console.WriteLine(count);
driver.Quit();