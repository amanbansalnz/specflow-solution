using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mar2021.Utilities
{
    class Wait
    {
        // generic function to wait - element exist
        public static void ElementExists(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
                }
            }
            catch(Exception ex)
            {
                Assert.Fail("Test failed waiting for element to exists", ex.Message);
            }
            

        }


        // generic function to wait - element clickable
        public static void ElementClickabe(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locator == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed waiting for element to exists", ex.Message);
            }


        }
    }
}
