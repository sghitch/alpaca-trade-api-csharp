using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alpaca.Markets
{
    /// <summary>
    /// Period units for portfolio history in the Alpaca REST API.
    /// </summary>
    [JsonConverter(typeof(SymbolTickerTypeConverter))]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public enum TickerType
    {
        /// <summary>
        /// Common Stock
        /// </summary>
        [EnumMember(Value = "CS")]
        Common,

        /// <summary>
        /// American Depository Receipt
        /// </summary>
        [EnumMember(Value = "ADR")]
        ADR,

        /// <summary>
        /// Non-Voting Depository Receipt
        /// </summary>
        [EnumMember(Value = "NVDR")]
        NVDR,

        /// <summary>
        /// Global Depositary Receipt
        /// </summary>
        [EnumMember(Value = "GDR")]
        GDR,

        /// <summary>
        /// Special Drawing Right
        /// </summary>
        [EnumMember(Value = "SDR")]
        SDR,

        /// <summary>
        /// Closed-End Fund
        /// </summary>
        [EnumMember(Value = "CEF")]
        CEF,

        /// <summary>
        /// Exchange Traded Product/Fund
        /// </summary>
        [EnumMember(Value = "ETP")]
        ETP,

        /// <summary>
        /// Real Estate Investment Trust
        /// </summary>
        [EnumMember(Value = "REIT")]
        REIT,

        /// <summary>
        /// Master Limited Partnership
        /// </summary>
        [EnumMember(Value = "MLP")]
        MLP,

        /// <summary>
        /// Equity WRT
        /// </summary>
        [EnumMember(Value = "WRT")]
        WRT,

        /// <summary>
        /// Public
        /// </summary>
        [EnumMember(Value = "PUB")]
        Public,

        /// <summary>
        /// New York Registry Shares
        /// </summary>
        [EnumMember(Value = "NYRS")]
        NYRS,

        /// <summary>
        /// Unit
        /// </summary>
        [EnumMember(Value = "UNIT")]
        Unit,

        /// <summary>
        /// Right
        /// </summary>
        [EnumMember(Value = "RIGHT")]
        Right,

        /// <summary>
        /// Tracking stock or targeted stock
        /// </summary>
        [EnumMember(Value = "TRAK")]
        Tracking,

        /// <summary>
        /// Limited Partnership
        /// </summary>
        [EnumMember(Value = "LTDP")]
        LTDP,

        /// <summary>
        /// Royalty Trust
        /// </summary>
        [EnumMember(Value = "RYLT")]
        RYLT,
        
        /// <summary>
        /// Mutual Fund
        /// </summary>
        [EnumMember(Value = "MF")]
        MF,

        /// <summary>
        /// Preferred Stock
        /// </summary>
        [EnumMember(Value = "PFD")]
        PFD,

        /// <summary>
        /// Foreign Ordinary Shares
        /// </summary>
        [EnumMember(Value = "FDR")]
        FDR,

        /// <summary>
        /// Other Security Type
        /// </summary>
        [EnumMember(Value = "OST")]
        Other,

        /// <summary>
        /// Fund
        /// </summary>
        [EnumMember(Value = "FUND")]
        Fund,

        /// <summary>
        /// Structured Product
        /// </summary>
        [EnumMember(Value = "SP")]
        SP,

        /// <summary>
        /// Secondary Issue
        /// </summary>
        [EnumMember(Value = "SI")]
        SI,

        /// <summary>
        /// Index
        /// </summary>
        [EnumMember(Value = "INDEX")]
        Index,

        /// <summary>
        /// Exchange Traded Fund (ETF)
        /// </summary>
        [EnumMember(Value = "ETF")]
        ETF,

        /// <summary>
        /// Exchange Traded Note (ETN)
        /// </summary>
        [EnumMember(Value = "ETN")]
        ETN,

        /// <summary>
        /// Exchange Traded Managed Fund (ETMF)
        /// </summary>
        [EnumMember(Value = "ETMF")]
        ETMF,

        /// <summary>
        /// Settlement
        /// </summary>
        [EnumMember(Value = "SETTLEMENT")]
        Settlement,

        /// <summary>
        /// Spot
        /// </summary>
        [EnumMember(Value = "SPOT")]
        Spot,

        /// <summary>
        /// Subordinated product
        /// </summary>
        [EnumMember(Value = "SUBPROD")]
        Subordinated,

        /// <summary>
        /// World Currency
        /// </summary>
        [EnumMember(Value = "WC")]
        WorldCurrency,

        /// <summary>
        /// Alpha Index
        /// </summary>
        [EnumMember(Value = "ALPHAINDEX")]
        AlphaIndex
    }
}
