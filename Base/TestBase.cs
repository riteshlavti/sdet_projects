using System.ComponentModel.DataAnnotations;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

[assembly: LevelOfParallelism(3)]

namespace TestProject
{
    public class TestBase
    {
        public WebDriver webDriver;
        public WebDriverWait wait;
        public HomePage homePage;
        protected ExtentReports extent;
        protected ExtentTest extentTest;
        protected IConfigurationRoot configuration;
        string browserName;

        public TestBase(string browserName)
        {
            this.browserName = browserName;
        }

        [OneTimeSetUp]
        public void ExtentStart()
        {
            string dir = @"D:\Training\FinalProject\Rdklu\TestReport\";
            string fileName = $"Report{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.html";
            ExtentSparkReporter sparkReporter = new ExtentSparkReporter(dir + fileName);
            extent = new ExtentReports();
            extent.AttachReporter(sparkReporter);

            configuration = new ConfigurationBuilder()
            .AddJsonFile(@"D:\Training\FinalProject\Rdklu\Config\data.json")
            .Build();
        }

        [SetUp]
        public void Setup()
        {
            if (browserName.Equals("chrome"))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");
                webDriver = new ChromeDriver(options);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            }
            else if (browserName.Equals("firefox"))
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("--disable-notifications");
                webDriver = new FirefoxDriver(options);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            }

            homePage = new HomePage(webDriver, wait);
            homePage.LoadUrl(configuration.GetSection("BaseUrl")["Url"]);
            homePage.ClosePopUp();
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
    }
}