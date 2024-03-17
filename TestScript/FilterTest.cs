using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class FilterTest : TestBase
    {
        public FilterTest(string browserName): base(browserName)
        {
        }

        [Test]
        public void VerifyProductSequence()
        {
            extentTest = extent.CreateTest("Verify product sequence after filtering").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                NavBarMenSectionTees navBarMenSectionTees = navBarMenSection.ClickOnTeesDropDown();
                PrintedTees printedTees = navBarMenSectionTees.ClickOnPrintedTees();
                printedTees.SetFilter();
                IList<IWebElement> productList = printedTees.GetProductsList();

                IWebElement firstProduct = productList[0];
                for (int i = 1; i < productList.Count; i++)
                {
                    Assert.That(productList[i].Text, Is.LessThanOrEqualTo(firstProduct.Text));
                    firstProduct = productList[i];
                }
                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw ;
            }
        }
    }
}