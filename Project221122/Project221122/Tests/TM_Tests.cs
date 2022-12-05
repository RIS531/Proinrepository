using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project221122.Pages;
using NUnit.Framework;
using Project221122.Utilities;



namespace Project221122.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : Commondriver
    {
       

        [Test,Order(1)]
        public void CreateTmTests()
        {
            Homepage HomePageObj = new Homepage();
            HomePageObj.gotoTMpage(driver);
            TimeMaterialpage tmPgobj = new TimeMaterialpage();
            tmPgobj.createTM(driver);
        }
        [Test, Order(2)]
        public void EditTest()
        {
            Homepage HomePageObj = new Homepage();
            HomePageObj.gotoTMpage(driver);
            //TimeMaterialpage EdPgobj = new TimeMaterialpage();
            //EdPgobj.EditTM(driver);

        }

        [Test, Order(3)]
        public void DeleteTest()
        {
            Homepage HomePageObj = new Homepage();
            HomePageObj.gotoTMpage(driver);
            TimeMaterialpage DelPageObj = new TimeMaterialpage();
            DelPageObj.deleteTM(driver);
        }



    }

}
