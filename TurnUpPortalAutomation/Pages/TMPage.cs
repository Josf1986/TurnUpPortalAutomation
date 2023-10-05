using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Pages
{
    public class TMPage
    {
        //Create a new Time Record
        public void CreateTimeRecord(IWebDriver driver)
        {
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
        }
        public void EditTimeRecord(IWebDriver driver) 
        {
            //Edit new Time Record
            Thread.Sleep(3000);

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
           
            EditButton.Click();

            Thread.Sleep(5000);
            driver.FindElement(By.Id("Code")).Clear();
            driver.FindElement(By.Id("Code")).SendKeys("Test Edit Practise");

            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("Test Edit Time");

            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            Thread.Sleep(3000);

            IWebElement newEditCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newEditCode.Text == "Test Edit Practise")
            {
                Console.WriteLine("New time record has been edited successfully");
            }
            else
            {
                Console.WriteLine("Time record has not been edited");
            }
        }
        public void DeleteTimeRecord(IWebDriver driver) 
        {
            //Delete the new Time Record

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            IWebElement DeletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (DeletedCode.Text == "Test Edit Practise")
            {
                Console.WriteLine("Edited time record has not been deleted");
            }
            else
            {
                Console.WriteLine("Edited time record has been deleted successsfully");
            }
        }
    }
}
