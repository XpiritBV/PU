using FeatureSwitcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartsUnlimited.FeatureSwitches
{
    public class NewArivalsAnnouncement : IFeature
    {
        public static string Name
        {
            get
            {
                return "New-Arivals";
            }
            internal
                set { }
        }
    }
}