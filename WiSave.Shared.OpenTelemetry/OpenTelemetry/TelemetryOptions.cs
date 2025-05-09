using OpenTelemetry.Exporter;

namespace WiSave.Shared.OpenTelemetry.OpenTelemetry;

public record TelemetryOptions
{
    public string TraceEndpoint { get; init; }
    public string LoggingEndpoint { get; init; }
    public OtlpExportProtocol Protocol { get; init; }
    public string Headers { get; init; }
}