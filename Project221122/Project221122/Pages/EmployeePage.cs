using NUnit.Framework;
using OpenQA.Selenium;
using Project221122.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project221122.Pages
{
    public class EmployeePage : Commondriver
    {

        private const int Seconds = 200;

        public void createEmployee(IWebDriver driver)
        {
          
            //create new record
            IWebElement CreateBtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateBtn.Click();

            //Enter Name
            IWebElement NameTBox = driver.FindElement(By.Id("Name"));
            NameTBox.SendKeys("Andrea");

            //Enter UserName
            IWebElement UserNameTBox = driver.FindElement(By.Id("Username"));
            UserNameTBox.SendKeys("Andyspark");
            //Enter contact
            IWebElement ContactTbox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            ContactTbox.SendKeys("1234567890");
            //IWebElement EdtContactBtn = driver.FindElement(By.Id("EditContactButton"));
            //EdtContactBtn.Click();
            //Thread.Sleep(500);
            ////Popup Form
            //IWebElement ContactName = driver.FindElement(By.Id("FirstName"));
            //ContactName.SendKeys("Andrea");
            //IWebElement ContactLastName = driver.FindElement(By.Id("LastName"));
            //ContactName.SendKeys("Spark");
            //IWebElement PhoneTbox = driver.FindElement(By.Id("Phone"));
            //PhoneTbox.SendKeys("1234567880");
            //IWebElement EmailTB = driver.FindElement(By.Id("email"));
            //EmailTB.SendKeys("LisaSpark123@gmail.com");
            //IWebElement SaveBtnForm = driver.FindElement(By.Id("submitButton"));
            //SaveBtnForm.Click();


            //Enter Password
            //IWebElement PwdTBox = driver.FindElement(By.Id("Password"));
            //PwdTBox.SendKeys("Industry2022");
            ////Retype Password
            //IWebElement RetypePwdBox = driver.FindElement(By.Id("RetypePassword"));
            //RetypePwdBox.SendKeys("Industry2022");
            IWebElement PwdTbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            PwdTbox.SendKeys("Industry2022");
            IWebElement RetypePwdBox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            RetypePwdBox.SendKeys("Industry2022");

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,100)");

             //Select checkbox
            //IWebElement AdminCBox = driver.FindElement(By.Id("IsAdmin"));
            //AdminCBox;

            //Select Vehicle dropdown box
            //select option 






            //select save
            //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            //saveButton.Click();
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));

            //   wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 14);

            //IWebElement lastbtn = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));

            //wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 200);
            //lastbtn.Click();
            //IWebElement NameTextBox= driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Assert.That(NameTextBox.Text == "Andrea", "Actual code and expected code do not match");

            

        }
    //public void EditEmployee(IWebDriver driver)
    //{
    /*

        IWebElement lastbtn = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));

        wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 80);
        lastbtn.Click();

        IWebElement Findnewrecordcreated = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        if (Findnewrecordcreated.Text == "Andrea")
        {

            IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editbtn.Click();

        }
        else
        {
            Assert.Fail("Record to be edited hasn't been found.Record not edited");
        }

        //Enter Name
        IWebElement NameTBox = driver.FindElement(By.Id("Name"));
        NameTBox.Clear();
        NameTBox.SendKeys("Jiya");

        //Enter UserName
        IWebElement UserNameTBox = driver.FindElement(By.Id("Username"));
        UserNameTBox.Clear();
        UserNameTBox.SendKeys("JP");
        //Enter contact
        IWebElement EdtContactBtn = driver.FindElement(By.Id("EditContactButton"));
        EdtContactBtn.Click();
        Thread.Sleep(500);
        //Popup Form
        IWebElement ContactName = driver.FindElement(By.Id("FirstName"));
        ContactName.Clear();
        ContactName.SendKeys("Jiya");
        IWebElement ContactLastName = driver.FindElement(By.Id("LastName"));
        ContactName.SendKeys("Spark");
        IWebElement PhoneTbox = driver.FindElement(By.Id("Phone"));
        PhoneTbox.SendKeys("1234567880");
        IWebElement EmailTB = driver.FindElement(By.Id("email"));
        EmailTB.SendKeys("LisaSpark123@gmail.com");
        IWebElement SaveBtnForm = driver.FindElement(By.Id("submitButton"));
        SaveBtnForm.Click();


        //Enter Password
        IWebElement PwdTBox = driver.FindElement(By.Id("Password"));
        PwdTBox.SendKeys("A1bcdefghi");
        //Retype Password
        IWebElement RetypePwdBox = driver.FindElement(By.Id("RetypePassword"));
        RetypePwdBox.SendKeys("A1bcdefghi");

        //Select checkbox
        //IWebElement AdminCBox = driver.FindElement(By.Id("IsAdmin"));
        //AdminCBox;

        //Select Vehicle dropdown box
        //select option 






        //select save
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();



        wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"container\"]/div/a", 80);
        IWebElement backtolist = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
        backtolist.Click();
        // click on last button
        wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]", seconds: Seconds);
        IWebElement lastpageeditbtn = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));

        wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 50);
        lastpageeditbtn.Click();
        IWebElement editname = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        Assert.That(editname.Text == "Jiya", "edit did not work");

        */


    //}
    //public void deleteEmployee(IWebDriver driver)
    //{
    /*
    wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", seconds: Seconds);
    IWebElement lastdeletebtn = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));

    wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 50);
    lastdeletebtn.Click();

    IWebElement Findnewrecordedited = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
    if (Findnewrecordedited.Text == "Jiya")
    {
        IWebElement DeleteBtn = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        DeleteBtn.Click();

        IAlert AlertBtn = driver.SwitchTo().Alert();
        AlertBtn.Accept();


    }
    else
    {
        Assert.Fail("Record to be deleted hasn't been found.Record not deleted");
    }
    */


    //}
    }
}
