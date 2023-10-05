using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TurnUpPortalAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        // Open chrome browser
        IWebDriver driver = new ChromeDriver();
        
        //Login page object initilization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page object initilization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);
     
        //TM page object initilization and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);

        tmPageObj.EditTimeRecord(driver);  
        
        tmPageObj.DeleteTimeRecord(driver);
    }
}