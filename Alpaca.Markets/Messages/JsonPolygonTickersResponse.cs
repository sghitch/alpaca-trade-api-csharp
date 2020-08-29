using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    [SuppressMessage(
        "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
        Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class JsonPolygonTickersResponse
    {
        [JsonProperty(PropertyName = "status", Required = Required.Default)]
        public String? Status { get; set; }

        [JsonProperty(PropertyName = "page", Required = Required.Default)]
        public Int64 Page { get; set; }

        [JsonProperty(PropertyName = "perPage", Required = Required.Default)]
        public Int64 PerPage { get; set; }

        [JsonProperty(PropertyName = "tickers", Required = Required.Default)]
        public List<JsonTicker>? ItemsList { get; set; }

        [JsonProperty(PropertyName = "count", Required = Required.Default)]
        public Int64 Count { get; set; }

        [JsonIgnore]
        public IReadOnlyList<ITicker> Items => ItemsList.EmptyIfNull<ITicker, JsonTicker>();
    }
}
