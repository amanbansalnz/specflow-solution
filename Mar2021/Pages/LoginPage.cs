using Mar2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mar2021.Pages
{
    class LoginPage
    {

        private IWebDriver driver;
        private IWebElement username => driver.FindElement(By.Id("UserName"));
        private IWebElement password => driver.FindElement(By.Name("Password"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
        private IWebElement loginErrorMessage => driver.FindElement(By.XPath("/html/body/div[4]/div/div/section/form/div[1]/ul/li"));
        private IWebElement helloHari => driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void loginSteps(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // maximize browser
            driver.Manage().Window.Maximize();


            try
            {
                Wait.ElementExists(driver, "Id", "UserName", 5);

                // identify and enter username
                username.SendKeys("hari");

                // identify and enter password
                password.SendKeys("123123");

                // identify and click login button
                loginButton.Click();
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }

            Wait.ElementExists(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 2);


            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }

        }

        public void enterGivenUsernameAndPasswordRefactored(string usernameValue, string passwordValue)
        {
            try
            {
                Wait.ElementExists(driver, "Id", "UserName", 5);


                if( usernameValue != null)
                {
                    Console.WriteLine("enterUsername " + usernameValue);

                    username.SendKeys(usernameValue);
                }else
                {
                    Console.WriteLine("enterUsername " + "hari");

                    username.SendKeys("hari");
                }


                if (passwordValue != null)
                {
                    Console.WriteLine("passwordValue " + passwordValue);
                    // enter password
                    password.SendKeys(passwordValue);
                }
                else {

                    Console.WriteLine("passwordValue " + "123123");
                    // enter default password
                    password.SendKeys("123123");

                }


            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }
        }

        public void login(string usernameValue, string passwordValue)
        {
            navigateToLoginPage();
            enterGivenUsernameAndPasswordRefactored(usernameValue, passwordValue);
            clickLoginButton();
            validateLoggedInSuccessfully();
        }



        public void navigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // maximize browser
            driver.Manage().Window.Maximize();
        }

        public bool validateThaYouAreLoginPage()
        {
            return loginButton.Displayed;
        }


        public void clickLoginButton()
        {
            loginButton.Click();
        }

        public bool validateLoggedInSuccessfully()
        {

            Wait.ElementExists(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 2);


            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
                return false;
            }

        }


        public bool validateNotLoggedIn()
        {

            Wait.ElementExists(driver, "XPath", "/html/body/div[4]/div/div/section/form/div[1]/ul/li", 5);
            return loginErrorMessage.Displayed;
            
        }
    }
}


