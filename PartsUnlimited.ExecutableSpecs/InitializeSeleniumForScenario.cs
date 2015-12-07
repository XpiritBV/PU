using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAutomation;


using PartsUnlimited.ExecutableSpecs.PageObjects;

using Specflow.FluentAutomation.Ext;

using TechTalk.SpecFlow;

namespace PartsUnlimited.ExecutableSpecs
{
    [Binding]
    public static class SpecflowCodedUI
    {
        [BeforeScenario("Selenium")]
        public static void SpecflowBeforeTestRun()
        {
            SeleniumWebDriver.Bootstrap(
                SeleniumWebDriver.Browser.PhantomJs
            );

            FluentSettings.Current.WindowHeight = 1080;
            FluentSettings.Current.WindowWidth = 1980;
        }

        [AfterScenario("Selenium")]
        public static void SpecflowAfterTestRun()
        {
            Pages.Get<BrowserWindow>().Close();
        }
    }
}
