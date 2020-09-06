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
    internal sealed class JsonCompanyDetails : ITicker, ICompanyDetails
    {
        [JsonProperty(PropertyName = "listdate", Required = Required.Default)]
        public DateTime? ListDate { get; set; }

        [JsonProperty(PropertyName = "cik", Required = Required.Default)]
        public String CIK { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "bloomberg", Required = Required.Default)]
        public String Bloomberg { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "figi", Required = Required.Default)]
        public String FIGI { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "lei", Required = Required.Default)]
        public String LEI { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "sic", Required = Required.Default)]
        public UInt64? SIC { get; set; }

        [JsonProperty(PropertyName = "country", Required = Required.Default)]
        public String Country { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "industry", Required = Required.Default)]
        public String Industry { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "sector", Required = Required.Default)]
        public String Sector { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "marketcap", Required = Required.Default)]
        public UInt64? MarketCap { get; set; }

        [JsonProperty(PropertyName = "employees", Required = Required.Default)]
        public UInt64? Employees { get; set; }

        [JsonProperty(PropertyName = "exchange", Required = Required.Default)]
        public String Exchange { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "name", Required = Required.Default)]
        public String Name { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "symbol", Required = Required.Always)]
        public String Symbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "exchangeSymbol", Required = Required.Default)]
        public String ExchangeSymbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "type", Required = Required.Default)]
        public TickerType? Type { get; set; }

        [JsonProperty(PropertyName = "similar", Required = Required.Default)]
        public IReadOnlyList<String> Similar { get; set; } = new List<String>();

        [JsonProperty(PropertyName = "active", Required = Required.Always)]
        public bool Active { get; set; }
    }
}
