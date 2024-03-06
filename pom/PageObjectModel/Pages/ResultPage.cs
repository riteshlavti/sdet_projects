using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.WebAuthn;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;

namespace PageObjectModel;

public class ResultPage
{
    public WebDriver driver;

    public ResultPage(WebDriver driver)
    {
        this.driver = driver;
        PageFactory.InitElements(driver,this);
    }

    public void TakeScreenshotAndSave1(string path)
    {
        ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(path);
    }

    public void TakeScreenshotAndSave2(string path)
    {
        driver.TakeScreenshot().SaveAsFile(path);
    }

    public void SwitchToAlertWindowAndAccept(IAlert alert)
    {
        alert.Accept();
    }
    
    public void SwitchToAlertWindowAndDismiss(IAlert alert)
    {
        alert.Dismiss();
    }

    public IAlert SwitchToAlertWindow()
    {
        return driver.SwitchTo().Alert();
    }

    public string GetAlertText(IAlert alert)
    {
        return alert.Text;
    }
}
