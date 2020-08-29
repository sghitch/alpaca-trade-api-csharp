using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// The base information for a ticker
    /// </summary>
    public interface ITicker
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
        public TickerType? Type { get; }
    }
}
