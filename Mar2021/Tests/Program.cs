using Mar2021.Pages;
using Mar2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Mar2021
{
    [TestFixture]
    [Parallelizable]
    class Program : CommonDriver
    {
        //static void Main(string[] args)
        //{

        //}



        [Test]
        public void CreateTMTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            // tm page object
            TMPage tmObj = new TMPage(driver);
            tmObj.createTM(driver);

        }

        [Test]
        public void EditTMTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            // tm page object
            TMPage tmObj = new TMPage(driver);
            tmObj.editTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            // tm page object
            TMPage tmObj = new TMPage(driver);
            tmObj.deleteTM(driver);
        }


    }
}
