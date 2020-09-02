using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    [SuppressMessage(
        "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
        Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class SymbolTickerTypeConverter : StringEnumConverter
    {
        public override Object? ReadJson(
            JsonReader reader,
            Type objectType,
            Object? existingValue,
            JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                if (reader.Value is string s)
                {
                    switch (s)
                    {
                        case "Common Stock":
                            return TickerType.Common;
                        case "Ordinary Shares":
                            return TickerType.Other;
                    }
                }

                throw;
            }
        }
    }
}
