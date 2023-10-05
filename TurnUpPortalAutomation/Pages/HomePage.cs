using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Pages
{
    public class HomePage
    { public void LoginSuccessCheck(IWebDriver driver)
            {        //Check if the user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User logged in successfully");
        }
        else
        {
            Console.WriteLine("User hasn't logged in");
        }

}
        public void GoToTMPage(IWebDriver driver)
        {
            // Navigate to time and material module
            IWebElement AdministrationDropdown = driver.FindElement(By.XPath($"/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropdown.Click();
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
