using System;
using System.Collections.Generic;

namespace Alpaca.Markets
{
    /// <summary>
    /// The detailed information for a ticker
    /// </summary>
    public interface ITickerDetails
    {
        /// <summary>
        /// CIK
        /// </summary>
        public String CIK { get; }

        /// <summary>
        /// Bloomberg
        /// </summary>
        public String Bloomberg { get; }

        /// <summary>
        /// FIGI
        /// </summary>
        public String FIGI { get; }

        /// <summary>
        /// LEI
        /// </summary>
        public String LEI { get; }

        /// <summary>
        /// SIC
        /// </summary>
        public UInt64? SIC { get; }

        /// <summary>
        /// Country
        /// </summary>
        public String Country { get; }

        /// <summary>
        /// Industry
        /// </summary>
        public String Industry { get; }

        /// <summary>
        /// Sector
        /// </summary>
        public String Sector { get; }

        /// <summary>
        /// MarketCap
        /// </summary>
        public UInt64? MarketCap { get; }

        /// <summary>
        /// Employees
        /// </summary>
        public UInt64? Employees { get; }

        /// <summary>
        /// Exchange
        /// </summary>
        public String Exchange { get; }

        /// <summary>
        /// Name
        /// </summary>
        public String Name { get; }

        /// <summary>
        /// Symbol
        /// </summary>
        public String Symbol { get; }

        /// <summary>
        /// ExchangeSymbol
        /// </summary>
        public String ExchangeSymbol { get; }

        /// <summary>
        /// Type
        /// </summary>
        public TickerType? Type { get; }

        /// <summary>
        /// Similar
        /// </summary>
        public IReadOnlyList<String> Similar { get; }

        /// <summary>
        /// Active
        /// </summary>
        public bool Active { get; set; }
    }
}
