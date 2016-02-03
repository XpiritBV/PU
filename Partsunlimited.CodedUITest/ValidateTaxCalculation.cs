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
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Partsunlimited.CodedUITest
{
    /// <summary>
    /// Summary description for ValidateSearchCodedUI
    /// </summary>
    [CodedUITest]
    public class ValidateTaxCalculation
    {
        public ValidateTaxCalculation()
        {
        }

        [TestMethod]
        [TestCategory("UI Test")]
        public void CalculateTax()
        {
            ApplicationUnderTest WinFormsApp = ApplicationUnderTest.Launch(@"C:\tmp\PUWindows\PartsUnlimited.Windows.exe");

            WinComboBox shopSelection = new WinComboBox(WinFormsApp);
            shopSelection.SearchProperties.Add(WinControl.PropertyNames.Name, "cmbStores");
            shopSelection.SelectedItem = "Store9";

            WinButton Logon = new WinButton(WinFormsApp);
            Logon.SearchProperties.Add(WinControl.PropertyNames.Name, "btnLogin");
            Mouse.Click(Logon);


            UIMap map = new UIMap();
            Mouse.Click(
            map.UIPartsUnlimitedStoreAWindow.UIMenuStrip1MenuBar.UIReportsToolstripMenuMenuItem);
            
            WinMenuItem taxcalculation = new WinMenuItem(map.UIPartsUnlimitedStoreAWindow.UIMenuStrip1MenuBar.UIReportsToolstripMenuMenuItem);
            taxcalculation.SearchProperties.Add(WinControl.PropertyNames.Name, "calculateTax");
                
            Mouse.Click(taxcalculation);

            var text = map.UICalculatedtax0Window.UICalculatedtax0Text.DisplayText;
            Assert.IsTrue(text.Contains("0"));

           
        }

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
