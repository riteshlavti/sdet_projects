using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class NavigationBarTest : TestBase
    {
        public NavigationBarTest(string browserName): base(browserName)
        {
        }
        By _printedTeesBtn = By.XPath("//a[contains(text(),'Printed Tees')]");
        By _poloTeesBtn = By.XPath("//a[contains(text(),'Polo Tees')]");
        By _raglanTeesBtn = By.XPath("//a[contains(text(),'Raglan Tees')]");
        By _pocketTeesBtn = By.XPath("//a[contains(text(),'Pocket Tees')]");
        By _basicOversizeTeesBtn = By.XPath("//a[contains(text(),'Basic Oversize Tee')]");
        By _athleticoActiveTeesBtn = By.XPath("//a[contains(text(),'Athletico - Active Wear Tees')]");

        [Test]
        public void TestVisibilityOfSubMenusInMenSection()
        {
            extentTest = extent.CreateTest("Test submenu visibility on men section").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                NavBarMenSectionTees navBarMenSectionTees = navBarMenSection.ClickOnTeesDropDown();
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_pocketTeesBtn));
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_basicOversizeTeesBtn));
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_raglanTeesBtn));
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_printedTeesBtn));
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_poloTeesBtn));

                navBarMenSectionTees.ClickOnActiveWearDropDown();
                Assert.IsTrue(navBarMenSectionTees.IsVisible(_athleticoActiveTeesBtn));

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