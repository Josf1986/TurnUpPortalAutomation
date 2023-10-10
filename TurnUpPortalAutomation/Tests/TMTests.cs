using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using NUnit.Framework;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {   
            // Open chrome browser
            driver = new ChromeDriver();

            //Login page object initilization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

        }
        [Test, Order(1), Description("This test creates a new Time record with valid data")]  
        public void TestCreateTimeRecord()
        {
            //Home page object initilization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TM page object initilization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Test, Order(2), Description("This test updates an existing Time record with valid data")]      
        public void TestEditTimeRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);
        }

        [Test, Order(3), Description("This test deletes an existing Time record")]
        public void TestDeleteTimeRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        { 
            driver.Quit();
        }
     
        
        
        
        
        
        
      

     
    }
}
