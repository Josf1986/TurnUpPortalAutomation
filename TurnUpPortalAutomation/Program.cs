using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch turnup portal and navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify username passwordbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify the login button and click on the button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

Thread.Sleep(5000); //waiting for mandatory 5 seconds

//Check if the user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User logged in successfully");
}
else 
{
    Console.WriteLine("User hasn't logged in");
}

// Test case - Create a new time record

// Navigate to time and material module
IWebElement AdministrationDropdown = driver.FindElement(By.XPath($"/html/body/div[3]/div/div/ul/li[5]/a"));
AdministrationDropdown.Click();
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

// Click on create new button
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();

// Select Time from dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typeCodeDropdown.Click();
IWebElement SelectTimeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
SelectTimeCode.Click();

// Enter Code
IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
CodeTextBox.SendKeys("Test Practise");

// Enter Description
IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
DescriptionTextBox.SendKeys("Test Time");

// Enter Price
IWebElement PriceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
PriceTextBox.SendKeys("150.00");

// Click on the Save button
IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();

Thread.Sleep(5000);

// Check if a new Time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "Test Practise")
{
    Console.WriteLine("New time record has been created successfully");
}
else
{
    Console.WriteLine("Time record has not been created");
}























