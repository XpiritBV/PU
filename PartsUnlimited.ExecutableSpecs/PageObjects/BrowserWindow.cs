using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAutomation;

namespace PartsUnlimited.ExecutableSpecs.PageObjects
{
    public class BrowserWindow : PageObject<BrowserWindow>
    {
        public BrowserWindow(FluentTest test) : base(test)
        { }

        public void Close()
        {
            I.Dispose();
        }
    }
}
