using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAutomation;

namespace PartsUnlimited.ExecutableSpecs.PageObjects
{
    public class BrowserWindow : PageObject<BrowserWindow>
    {
        public BrowserWindow(FluentTest test) : base(test)
        {
            test.With.WindowSize(1920, 1080).WaitOnAllActions(true);
        }

        public void Close()
        {
            I.Dispose();
        }
    }
}
