using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium;

namespace Partsunlimited.SeleniumTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    [DeploymentItem("chromedriver.exe")]
    [DeploymentItem("IEDriverServer.exe")]
    public class ValidateSearchSelenium
    {
        public ValidateSearchSelenium()
        {
        }

        [TestMethod]
        [TestCategory("UI Test")]
        public void BuyOneProductSelenium()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5001");
            var lightingCategoryLink = driver.FindElementByCssSelector(".category-menu > div:nth-child(1) > div:nth-child(1) > ul:nth-child(1) > li:nth-child(2) > a:nth-child(1)");
            

            lightingCategoryLink.Click();

            var lightingProduct = driver.FindElementByCssSelector("div.col-lg-3:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
            lightingProduct.Click();

            var ProductLink = driver.FindElementByCssSelector(".btn");


            Assert.IsNotNull(ProductLink);

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
