using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates request parameters for <see cref="PolygonDataClient.ListTickersAsync(TickerType?, System.Threading.CancellationToken)"/> call.
    /// </summary>
    public sealed class TickersRequest
    {
        /// <summary>
        /// Gets or sets asset type for filtering.
        /// </summary>
        public TickerType? Type { get; set; }

        /// <summary>
        /// Gets or sets the page of results to return
        /// </summary>
        public uint Page { get; set; } = 1;

        internal UriBuilder GetUriBuilder(
            PolygonDataClient polygonDataClient)
        {
            var builder = polygonDataClient.GetUriBuilder(
                $"/v2/reference/tickers");

            builder.QueryBuilder
                .AddParameter("locale", "us")
                .AddParameter("active", "true")
                .AddParameter("page", $"{Page}");
            if (Type.HasValue)
            {
                builder.QueryBuilder.AddParameter("type", Type?.ToEnumString());
            }

            return builder;
        }
    }
}
