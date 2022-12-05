using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Project221122.Pages;
using Project221122.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Project221122.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : Commondriver
    {
        Loginpage loginPgobj = new Loginpage();
        TimeMaterialpage tmpgobj = new TimeMaterialpage();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            
            loginPgobj.loginTasks(driver);
        }

        [When(@"I navigate to Time and material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            Homepage HomePageObj = new Homepage();
            HomePageObj.gotoTMpage(driver);
        }

        [When(@"I create new Time and Material Record")]
        public void WhenICreateNewTimeAndMaterialRecord()
        {
           
            tmpgobj.createTM(driver);

        }

        [Then(@"Record should be created successfully")]
        public void ThenRecordShouldBeCreatedSuccessfully()
        {
            
            string NewCode = tmpgobj.Getcode(driver);
            string NewDesc = tmpgobj.GetDescription(driver);
            string NewPrice = tmpgobj.GetPrice(driver);
            Assert.That(NewCode == "gherkin", "Actual code and expected code do not match");
            Assert.That(NewDesc == "First", "Actual description and expected description do not match");
            Assert.That(NewPrice == "$12.00", "Actual price and expected price do not match");
        }

        [When(@"I updated '([^']*)', '([^']*)', '([^']*)' on an existing Time record")]
        public void WhenIUpdatedOnAnExistingTimeRecord(string description, string code, string price)
        {
            //TimeMaterialpage EdPgobj = new TimeMaterialpage();
            tmpgobj.EditTM(driver, description, code, price);

        }
        [Then(@"The record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string Description, string code, string price)
        {
            //TimeMaterialpage Tmpgobj = new TimeMaterialpage();
             string editeddescription = tmpgobj.GetEditedDescription(driver);
            string editedcode = tmpgobj.GetEditedCode(driver);
            string editedprice = tmpgobj.GetEditedPrice(driver);
            Assert.That(editeddescription == Description, "Actual description and edited desciption does not match");
            Assert.That(editedcode == code, "Actual code and edited code does not match");
            Assert.That(editedprice == price, "Actual price and edited price does not match");

        }





    }
}
