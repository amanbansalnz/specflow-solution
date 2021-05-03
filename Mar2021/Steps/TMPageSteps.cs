using System;
using Mar2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mar2021.Steps
{
    [Binding]
    public class TMPageSteps
    {

        private readonly IWebDriver driver;
        private TMPage tmPage;
        private LoginPage loginPage;
        private HomePage homePage;



        public TMPageSteps()
        {
            driver = new ChromeDriver(@"/Users/aman.bansal/Projects/Mar2021/Mar2021/");
            tmPage = new TMPage(driver);
            loginPage = new LoginPage(driver);
             homePage = new HomePage();
        }


        [Given("I am logged in")]
        public void GivenIamloggedIn()
        {
            loginPage.login(null, null);
            Console.WriteLine("I am logged in");
        }

        [Given("I am at the TMPage")]
        public void GivenIAmAtTheTMPage()
        {
            homePage.navigateToTM(driver);
            bool isAtTmPage = tmPage.validateAtTmPage();

            Assert.IsTrue(isAtTmPage);
            Console.WriteLine("I am at the TMPage");
        }

        [When("I click the create new button")]
        public void WhenIPressAdd()
        {

            tmPage.clickCreateButton();
            Console.WriteLine("I click the create new button");
        }


        [When("I enter the details for the new TM")]
        public void WhenIEnterTheDetailsForTheNewTM()
        {
            tmPage.selectingTimeMaterial();
            tmPage.enterInputCode(null);
            tmPage.enterInputDescription(null);
            tmPage.inputPriceValue();
            Console.WriteLine("I enter the details for the new TM");
        }

        [When("Click save button")]
        public void WhenClickSaveButton()
        {
            tmPage.clickSave();
            Console.WriteLine("Click save button");
        }

        [When("I click the last page button")]
        public void WhenIClickTheLastPageButton()
        {
            tmPage.clickToLastPage();
            Console.WriteLine("I click the last page button");
        }


        [Then("Validate the TM is created")]
        public void ThenValidateTheTMIsCreated()
        {
            bool isValidate = tmPage.validateNewTMIsCreated();
            Console.WriteLine("Validate the TM is created");
            Assert.IsTrue(false);
        }
    }
}
