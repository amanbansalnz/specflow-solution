using System;
using Mar2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mar2021.Steps
{
    [Binding]
    public class LoginPageSteps
    {

        private readonly IWebDriver driver;
        private LoginPage loginPage;


        public LoginPageSteps()
        {
            driver = new ChromeDriver(@"/Users/aman.bansal/Projects/Mar2021/Mar2021/");
            loginPage = new LoginPage(driver);

        }


        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }


        [Given("I am at the login page")]
        public void GiveIAmAtTheLoginPage()
        {
            loginPage.navigateToLoginPage();
            Console.WriteLine("I am at the login page");
        }

        [Given(@"I validate that I am at the login page")]
        public void GivenIValidateThatIAmAtTheLoginPage()
        {

            bool isAtLoginPage = loginPage.validateThaYouAreLoginPage();
            Assert.IsTrue(isAtLoginPage);
        }


        [When("I enter valid creds")]
        public void WhneIValidCreds()
        {


            loginPage.enterGivenUsernameAndPasswordRefactored(null, null);


            Console.WriteLine("I enter valid creds");

        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.clickLoginButton();
            Console.WriteLine("I click the login button");

        }

        [When("I login with username '(.*)'")]
        public void WhenILoginWithUsername(string username)
        {

            loginPage.enterGivenUsernameAndPasswordRefactored(username, null);
            Console.WriteLine("When I login with username =" + username);

        }


        [When(@"I login with (.*) and with (.*)")]
        public void WhenILoginWithUsername(string username, string password)
        {


            loginPage.enterGivenUsernameAndPasswordRefactored(username, password);
            Console.WriteLine("I login with username =" + username + " and with password =" + password);

        }


        [Then(@"I should be not logged in")]
        public void ThenIShouldBeNotLoggedIn()
        {
            bool isNotLoggedIn = loginPage.validateNotLoggedIn();
            Console.WriteLine("I should be not logged in");
            Assert.IsTrue(isNotLoggedIn);

        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {

            bool isLoggedIn = loginPage.validateLoggedInSuccessfully();
            Console.WriteLine("I should be logged in successfully");

            Assert.IsTrue(isLoggedIn);

        }

    }
}
