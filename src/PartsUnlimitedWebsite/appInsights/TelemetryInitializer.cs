using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility;
using System.Diagnostics;
using Microsoft.ApplicationInsights.DataContracts;

namespace PartsUnlimited.appInsights
{

    public class TelemetryInitializer : ITelemetryInitializer
    {
        public void Initialize(Microsoft.ApplicationInsights.Channel.ITelemetry telemetry)
        {
            telemetry.Context.Properties["E2ETrace.ActivityID"] = Trace.CorrelationManager.ActivityId.ToString();
            telemetry.Context.Properties["Environment"] = System.Configuration.ConfigurationManager.AppSettings["environment"];
        }
    }

    public class TelemetryContextInitializer : IContextInitializer
    {
        public void Initialize(TelemetryContext context)
        {
            context.Properties["Environment"] = System.Configuration.ConfigurationManager.AppSettings["environment"];
        }
    }
}


