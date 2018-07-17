using System;
using Alpaca.Markets.Enums;
using Xunit;

namespace Alpaca.Markets.Tests
{
    public sealed class RestClientPolygonTest
    {
        private readonly RestClient _restClient = ClientsFactory.GetRestClient();

        [Fact]
        public async void GetExchangesWorks()
        {
            var exchanges = await _restClient.GetExchangesAsync();

            Assert.NotNull(exchanges);
            Assert.NotEmpty(exchanges);
        }

        [Fact]
        public async void GetSymbolTypeMapWorks()
        {
            var symbolTypeMap = await _restClient.GetSymbolTypeMapAsync();

            Assert.NotNull(symbolTypeMap);
            Assert.NotEmpty(symbolTypeMap);
        }

        [Fact]
        public async void GetHistoricalTradesWorks()
        {
            var historicalItems = await _restClient
                .GetHistoricalTradesAsync("AAPL", DateTime.Today);

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public async void GetHistoricalQuotesWorks()
        {
            var historicalItems = await _restClient
                .GetHistoricalQuotesAsync("AAPL", DateTime.Today);

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public async void GetDayAggregatesWorks()
        {
            var historicalItems = await _restClient
                .GetDayAggregatesAsync("AAPL");

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public async void GetMinuteAggregatesWorks()
        {
            var historicalItems = await _restClient
                .GetMinuteAggregatesAsync("AAPL");

            Assert.NotNull(historicalItems);

            Assert.NotNull(historicalItems.Items);
            Assert.NotEmpty(historicalItems.Items);
        }

        [Fact]
        public async void GetLastTradeWorks()
        {
            var lastTrade = await _restClient
                .GetLastTradeAsync("AAPL");

            Assert.NotNull(lastTrade);
            Assert.True(lastTrade.Time.Kind == DateTimeKind.Utc);
        }

        [Theory]
        [InlineData(TickType.Trades)]
        [InlineData(TickType.Quotes)]
        public async void GetConditionMapForQuotesWorks(
            TickType tickType)
        {
            var conditionMap = await _restClient.GetConditionMapAsync(tickType);

            Assert.NotNull(conditionMap);
            Assert.NotEmpty(conditionMap);
        }
    }
}