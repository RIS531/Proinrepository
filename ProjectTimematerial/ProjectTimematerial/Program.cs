///open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//lunch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
//identify password textbox and exter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
//click login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
//check if user has logged in successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text == "Hello hari!")
{
    Console.Write("Login successful,test passed.");
}
else
{
    Console.Write("Login failed,test failed.");
}
//click administration
IWebElement adminDropdownbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminDropdownbox.Click();
//goto time&material page
IWebElement timematerialopt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timematerialopt.Click();
//create new
IWebElement creatButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
creatButton.Click();
//select typecode 
IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
//enter code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Automation");
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
//check whether data saved or not
Thread.Sleep(2000);
/*
// check if new time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();
Thread.Sleep(10000);
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "November2022")
{
    Console.WriteLine("Time record created successfully.");
}
else
{
    Console.WriteLine("Time record hasn't been created successfully");
}
*/
