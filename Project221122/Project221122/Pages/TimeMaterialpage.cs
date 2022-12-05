using NUnit.Framework;
using OpenQA.Selenium;
using Project221122.Utilities;
using OpenQA.Selenium.Support.UI;
using NuGet.Frameworks;

namespace Project221122.Pages
{
    public class TimeMaterialpage
    {
        private const int Seconds = 200;

        public void createTM(IWebDriver driver)
        {
            //create new
            IWebElement creatButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            creatButton.Click();
           
            //select typecode 
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));//(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typecodeDropdown.Click();
            Thread.Sleep(500);
            IWebElement timeopt = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeopt.Click();
            Thread.Sleep(500);
            

            //enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("gherkin");

            //enter discription
            IWebElement discTextbox = driver.FindElement(By.Id("Description"));
            discTextbox.SendKeys("First");
            //price
            IWebElement overlapTab = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlapTab.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");
            //select save
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 14);
            
            IWebElement lastbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            
             wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 50);
            lastbtn.Click();
            //IWebElement NewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            // Assert.That(NewCode.Text=="Automation","Actual code and expected code do not match");
            
           

        }
        public String Getcode(IWebDriver driver)
        {
            IWebElement ActualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return ActualCode.Text;
        }
        public String GetDescription(IWebDriver driver)
        {
            IWebElement ActualDesc = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return ActualDesc.Text;
        }
        public String GetPrice(IWebDriver driver)
        {
            IWebElement ActualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return ActualPrice.Text;
        }
        public void EditTM(IWebDriver driver,string description,string edtcode,string edtprice)
        {
            
            IWebElement lastbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            
             wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 80);
            lastbtn.Click();
            
            //IWebElement Findnewrecordcreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //if (Findnewrecordcreated.Text == "gherkin")
           // {
               
                IWebElement editbtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editbtn.Click();
                
            //}
            //else
            //{
               // Assert.Fail("Record to be edited hasn't been found.Record not edited");
            //}
              
              IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
              codeTextbox.Clear();
              codeTextbox.SendKeys(edtcode);
              Thread.Sleep(500);
              IWebElement descTextbox = driver.FindElement(By.Id("Description"));
              descTextbox.Clear();
              descTextbox.SendKeys(description);
              Thread.Sleep(500);

            IWebElement OverlapeditTB = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement PriceTB = driver.FindElement(By.Id("Price"));
            OverlapeditTB.Click();
            PriceTB.Clear();
            OverlapeditTB.Click();
            PriceTB.SendKeys(edtprice);
            IWebElement SaveBTN = driver.FindElement(By.Id("SaveButton"));
              SaveBTN.Click();


            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"container\"]/div/a", 80);
            IWebElement backtolist = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolist.Click();
            // click on last button
            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", seconds: Seconds);
            IWebElement lastpageeditbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 50);
            lastpageeditbtn.Click();
            //IWebElement editname = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //Assert.That(editname.Text == "Edittask", "edit did not work");


        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement ActualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            return ActualDescription.Text;

        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement ActualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            return ActualCode.Text;

        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement ActualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            string temp = ActualPrice.Text;
            Console.WriteLine(temp);
            return ActualPrice.Text;

        }
        public void deleteTM(IWebDriver driver)
        {
            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", seconds: Seconds);
            IWebElement lastdeletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));

            wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 50);
            lastdeletebtn.Click();

            IWebElement Findnewrecordedited = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (Findnewrecordedited.Text == "Edittask")
            {
                IWebElement DeleteBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                DeleteBtn.Click();

                IAlert AlertBtn = driver.SwitchTo().Alert();
                AlertBtn.Accept();


            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found.Record not deleted");
            }



        }
    }
}
