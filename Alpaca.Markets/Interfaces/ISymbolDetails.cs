using System;
using System.Collections.Generic;

namespace Alpaca.Markets
{
    /// <summary>
    /// The detailed information for a Symbol
    /// </summary>
    public interface ISymbolDetails
    {
        /// <summary>
        /// Symbol
        /// </summary>
        public String Symbol { get; }

        /// <summary>
        /// Name
        /// </summary>
        public String Name { get; }

        /// <summary>
        /// Type
        /// </summary>
        public TickerType Type { get; }

        /// <summary>
        /// Updated UTC
        /// </summary>
        public DateTime UpdatedUTC { get; }

        /// <summary>
        /// Is OTC
        /// </summary>
        public bool IsOTC { get; }

        /// <summary>
        /// Primary Exchange
        /// </summary>
        public UInt64 PrimaryExchange { get; }

        /// <summary>
        /// Exchange Symbol
        /// </summary>
        public String ExchangeSymbol { get; }

        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; }
    }
}
