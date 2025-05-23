namespace WiSave.Shared.OpenTelemetry.OpenTelemetry;

public static class TelemetryTags
{
    public static class Logic
    {
        public static class  Entities
        {
            public const string Entity = $"{ActivitySourceProvider.DefaultSourceName}.entity";
            public const string EntityType = $"{Entity}.type";
            public const string EntityId = $"{Entity}.id";
            public const string EntityVersion = $"{Entity}.version";
        }

        public const string Stream = $"{ActivitySourceProvider.DefaultSourceName}.stream";
    }

    public static class Commands
    {
        public const string Command = $"{ActivitySourceProvider.DefaultSourceName}.command";
        public const string CommandType = $"{Command}.type";
        public const string CommandsMeter = $"{ActivitySourceProvider.DefaultSourceName}.commands";
        public const string CommandHandling = $"{CommandsMeter}.handling";
        public const string ActiveCommandsNumber = $"{CommandHandling}.active.number";
        public const string TotalCommandsNumber = $"{CommandHandling}.total";
        public const string CommandHandlingDuration = $"{CommandHandling}.duration";
    }

    public static class QueryHandling
    {
        public const string Query = $"{ActivitySourceProvider.DefaultSourceName}.query";
    }

    public static class EventHandling
    {
        public const string Event = $"{ActivitySourceProvider.DefaultSourceName}.event";
    }

    public static class Service
    {
        public const string Name = "service.name";
        public const string PeerName = "peer.service";
    }

    public static class Messaging
    {
        public const string System = "messaging.system";

        public static class Operation
        {
            public const string Key = "messaging.operation";
            public const string Receive = "receive";
            public const string Send = "send";
            public const string Process = "process";
        }

        public const string Destination = "messaging.destination";
        public const string DestinationKind = "messaging.destination_kind";
        public const string TempDestination = "messaging.temp_destination";
        public const string Protocol = "messaging.protocol";
        public const string ProtocolVersion = "messaging.protocol_version";
        public const string Url = "messaging.url";
        public const string MessageId = "messaging.message_id";
        public const string ConversationId = "messaging.conversation_id";
        public const string MessagePayloadSizeBytes = "messaging.message_payload_size_bytes";
        public const string MessagePayloadCompressedSizeBytes = "messaging.message_payload_compressed_size_bytes";
        public const string NetPeerName = "net.peer.name";
        public const string NetSocketFamily = "net.sock.family";
        public const string NetSocketPeerAddress = "net.sock.peer.addr";
        public const string NetSocketPeerName = "net.sock.peer.name";
        public const string NetSocketPeerPort = "net.sock.peer.port";

        public static class Consumers
        {
            public const string ConsumerId = "consumer_id";
        }
    }
}