using Mar2021.Pages;
using Mar2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mar2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class CompaniesTest : CommonDriver
    {



        [Test]
        public void CreateCompanyTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            // company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.CreateCompany(driver);

        }

        [Test]
        public void EditCompanyTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            // company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.EditCompany(driver);
        }

        [Test]
        public void DeleteCompanyTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            // company page object
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.DeleteCompany(driver);
        }


    }
}
