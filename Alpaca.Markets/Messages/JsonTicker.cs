using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
        [SuppressMessage(
        "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
        Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class JsonTicker : ITicker
    {
        [JsonProperty(PropertyName = "ticker", Required = Required.Always)]
        public String Symbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "name", Required = Required.Default)]
        public String Name { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "type", Required = Required.Default)]
        [JsonConverter(typeof(StringEnumConverter))]
        public TickerType? Type { get; set; }
    }
}
