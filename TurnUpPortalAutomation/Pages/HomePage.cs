using OpenQA.Selenium;

namespace TurnUpPortalAutomation.Pages
{
    public class HomePage
    {   public void GoToTMPage(IWebDriver driver)
        {
            // Navigate to time and material module
            IWebElement AdministrationDropdown = driver.FindElement(By.XPath($"/html/body/div[3]/div/div/ul/li[5]/a"));
            AdministrationDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
