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
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace Partsunlimited.CodedUITest
{
    /// <summary>
    /// Summary description for ValidateSearchCodedUI
    /// </summary>
    [CodedUITest]
    public class ValidateSearchCodedUI
    {
        public ValidateSearchCodedUI()
        {
        }

        [TestMethod]
        [TestCategory("UI Test")]
        public void BuyOneProductCodedUI()
        {

            var bw = BrowserWindow.Launch("http://localhost:5001");            HtmlDiv categoryDiv = new HtmlDiv(bw);
            categoryDiv.SearchProperties.Add(HtmlControl.PropertyNames.Class, "hidden-xs", PropertyExpressionOperator.Contains);
            
            HtmlHyperlink lightingCategoryLink = new HtmlHyperlink(categoryDiv);
            lightingCategoryLink.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, "Lighting", PropertyExpressionOperator.Contains);
      
            Mouse.Click(lightingCategoryLink);
            HtmlDiv Container = new HtmlDiv(bw);
            Container.SearchProperties.Add(HtmlControl.PropertyNames.Class, "container", PropertyExpressionOperator.Contains);
      

            HtmlHyperlink lightingProduct = new HtmlHyperlink(bw);
            lightingProduct.SearchProperties.Add(HtmlControl.PropertyNames.Title, "Halogen Headlights", PropertyExpressionOperator.Contains);

            Mouse.Click(lightingProduct);


            HtmlHyperlink ProductLink = new HtmlHyperlink(bw);
            ProductLink.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, "Add to Cart", PropertyExpressionOperator.Contains);


            Assert.IsTrue(ProductLink.TryFind());
        }

        private void OnPlaybackError(object sender, PlaybackErrorEventArgs e)
        {
            e.Result = PlaybackErrorOptions.Retry;
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
