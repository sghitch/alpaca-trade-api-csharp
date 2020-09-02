using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    [SuppressMessage(
    "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
    Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class JsonSymbolDetails : ISymbolDetails
    {
        [JsonProperty(PropertyName = "symbol", Required = Required.Always)]
        public String Symbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "name", Required = Required.Default)]
        public String Name { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "type", Required = Required.Default)]
        public TickerType? Type { get; set; }

        [JsonProperty(PropertyName = "updated", Required = Required.Default)]
        public DateTime? UpdatedUTC { get; set; }

        [JsonProperty(PropertyName = "isOTC", Required = Required.Always)]
        public bool IsOTC { get; set; }

        [JsonProperty(PropertyName = "primaryExchange", Required = Required.Default)]
        public UInt64? PrimaryExchange { get; set; }

        [JsonProperty(PropertyName = "exchSym", Required = Required.Default)]
        public String ExchangeSymbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "active", Required = Required.Always)]
        public bool Active { get; set; }
    }
}
