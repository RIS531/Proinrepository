using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project221122.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project221122.Utilities
{
    public class Commondriver
    {
        public static IWebDriver  driver;

        [OneTimeSetUp]
        public void LoginSteps()
        {
             driver = new ChromeDriver();
            //login page object initialization and definition
            Loginpage loginPgobj = new Loginpage();
            loginPgobj.loginTasks(driver);


        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
