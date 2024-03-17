using AventStack.ExtentReports;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class HomePageTest : TestBase
    {
        public HomePageTest(string browserName) : base(browserName)
        {
        }

        [Test]
        public void LandedOnHomePage()
        {
            extentTest = extent.CreateTest("HomePage Test").Info("Test Started");
            try
            {
                Assert.That(homePage.GetCurrentUrl(), Is.EqualTo(configuration.GetSection("BaseUrl")["Url"]));
                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw;
            }
        }
    }
}