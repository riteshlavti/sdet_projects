using System.IO.Compression;
using AventStack.ExtentReports;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class DiscountVerification : TestBase
    {
        public DiscountVerification(string browserName): base(browserName)
        {
        }
        
        [Test]
        public void DiscountVerificationTest()
        {
            extentTest = extent.CreateTest("Discount verification test").Info("Test Started");
            try
            {
                DealOfTheDayPage dealOfTheDayPage = homePage.GoToDealOfTheDayPage();
                dealOfTheDayPage.StoreProductsPriceDetails();
                for (int i = 0; i < 5; i++)
                {
                    int expectedPrice = dealOfTheDayPage.StringToInt(dealOfTheDayPage.discountPercentageList[i].Text)
                                        * dealOfTheDayPage.StringToInt(dealOfTheDayPage.originalPriceList[i].Text) / 100;
                    int actualPrice = dealOfTheDayPage.StringToInt(dealOfTheDayPage.discountedPriceList[i].Text);
                    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
                }
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