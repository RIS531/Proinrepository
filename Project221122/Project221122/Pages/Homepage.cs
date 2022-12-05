using OpenQA.Selenium;


namespace Project221122.Pages
{
    public class Homepage
    {
        public void gotoTMpage(IWebDriver driver)
        {
            //click administration
            IWebElement adminDropdownbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdownbox.Click();
            //goto time&material page
            IWebElement timematerialopt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialopt.Click();
        }
        public void gotoEmployeePage(IWebDriver driver)
        {
            //click administration
            IWebElement adminDropdownbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdownbox.Click();
            //goto Employee page
            IWebElement Employeeopt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeeopt.Click();

        }

    }
}
