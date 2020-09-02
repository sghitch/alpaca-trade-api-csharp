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
    internal sealed class JsonSymbolResponse 
    {
        [JsonProperty(PropertyName = "symbol", Required = Required.Always)]
        public JsonSymbolDetails? Details { get; set; }
    }
}
