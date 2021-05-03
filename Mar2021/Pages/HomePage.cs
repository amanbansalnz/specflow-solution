using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mar2021.Pages
{
    class HomePage
    {
        public void navigateToTM(IWebDriver driver)
        {
            // click admin
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(500);

            // click tm
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }


        public void navigateToCompanies(IWebDriver driver)
        {
            // click admin
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(500);

            // click companies - to-do
            
        }
    }
}
