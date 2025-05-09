using Microsoft.Extensions.Hosting;
using OpenTelemetry.Resources;
using Telemetry = OpenTelemetry.Resources;

namespace WiSave.Shared.OpenTelemetry.OpenTelemetry;

public static class ResourceBuilder
{
    private const string DefaultServiceVersion = "1.0.0";
    public static Telemetry.ResourceBuilder CreateResourceBuilder(IHostEnvironment environment) =>
        Telemetry.ResourceBuilder.CreateDefault()
            .AddService(environment.ApplicationName, serviceVersion: DefaultServiceVersion)
            .AddTelemetrySdk()
            .AddAttributes(new Dictionary<string, object>
            {
                ["deployment.environment"] = environment.EnvironmentName.ToLowerInvariant()
            });

}