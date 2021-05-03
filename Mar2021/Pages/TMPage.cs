using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mar2021.Pages
{
    class TMPage
    {
        private IWebDriver driver;
        private IWebElement createNewButton => driver.FindElement(By.XPath("//*[@id='container']/p/a"));
        private IWebElement materialDropdown => driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
        private IWebElement timerMaterialDropdown => driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
        private IWebElement inputCode => driver.FindElement(By.Id("Code"));
        private IWebElement inputDescription => driver.FindElement(By.XPath("//*[@id='Description']"));
        private IWebElement inputPriceTextBox => driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
        private IWebElement inputPrice => driver.FindElement(By.XPath("//*[@id='Price']"));
        private IWebElement saveButton => driver.FindElement(By.XPath("//*[@id='SaveButton']"));
        private IWebElement lastPageButton => driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
        private IWebElement totalNumberCountOfItems => driver.FindElement(By.XPath("//*[@data-role='pager']/span[2]"));
        private IWebElement lastEntryDescription => driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

        public TMPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public bool validateAtTmPage()
        {
            // expect delay
            Thread.Sleep(500);

            // click create new button
            return createNewButton.Displayed;

        }


        public void clickCreateButton()
        {
            // expect delay
            Thread.Sleep(500);

            // click create new button
             createNewButton.Click();

            // expect delay
            Thread.Sleep(500);
        }

        public void selectingTimeMaterial()
        {
            // select time from drop down
            materialDropdown.Click();
            Thread.Sleep(500);
            timerMaterialDropdown.Click();
        }


        public void enterInputCode(string input)
        {

            if(input == null)
            {
                inputCode.SendKeys("Mar2021");
            }
            else
            {
                inputCode.SendKeys(input);

            }
        }

        public void enterInputDescription(string description)
        {

            if (description == null)
            {
                inputDescription.SendKeys("Mar2021");
            }
            else
            {
                inputDescription.SendKeys(description);

            }
        }


        public void inputPriceValue()
        {
            inputPriceTextBox.Click();
            inputPrice.SendKeys("765");
        }


        public void clickSave()
        {
           saveButton.Click();
 
            // expect delay
            Thread.Sleep(2500);

        }


        public void clickToLastPage()
        {
            lastPageButton.Click();
            Thread.Sleep(500);

        }


        public bool validateNewTMIsCreated()
        {
            // verify if the last row contains the record created
            IWebElement actualDescription = lastEntryDescription;

            // option 1
            //Assert.That(actualDescription.Text, Is.EqualTo("Mar2021"), "Test Failed");

            // option 2
            if (actualDescription.Text == "Mar2021")
            {

                //Assert.Pass("TM created, test passed");
                return true;
            }
            else
            {
                return false;
                //Assert.Fail("TM test failed");
            }
        }


        public void createTM(IWebDriver driver)
        {
            // *****Create new TM test



            // expect delay
            Thread.Sleep(500);

            // click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // expect delay
            Thread.Sleep(500);

            // select time from drop down
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();


            // input code
            driver.FindElement(By.Id("Code")).SendKeys("Mar2021");

            // input description 
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Mar2021");

            // input price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("765");

            // upload file - to-do
            // click save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            // expect delay
            Thread.Sleep(2500);

            // verify create

            // go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(500);

            // record count
            string recordCount = driver.FindElement(By.XPath("//*[@data-role='pager']/span[2]")).Text;



            // verify if the last row contains the record created
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            // option 1
            Assert.That(actualDescription.Text, Is.EqualTo("Mar2021"), "Test Failed");

            // option 2
            if (actualDescription.Text == "Mar2021")
            {
                Assert.Pass("TM created, test passed");
            }
            else
            {
                Assert.Fail("TM test failed");
            }
        }

        public void editTM(IWebDriver driver)
        {
            // **** Edit test script
        }

        public void deleteTM(IWebDriver driver)
        {
            // **** Delete test script

        }
    }
}
