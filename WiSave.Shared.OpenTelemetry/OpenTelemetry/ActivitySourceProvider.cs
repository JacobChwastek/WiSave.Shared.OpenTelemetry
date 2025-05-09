using System.Diagnostics;

namespace WiSave.Shared.OpenTelemetry.OpenTelemetry;

public static class ActivitySourceProvider
{
    public const string DefaultSourceName = "wisave";
    public static readonly ActivitySource Instance = new(DefaultSourceName, "v1");
}