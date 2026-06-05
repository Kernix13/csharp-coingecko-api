using System.Text.Json;
using CoinGeckoAPI;

using HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("User-Agent", "CSharpCoinGeckoApp/1.0");

// Access Currency Enum
Currency targetCurrency = Currency.Usd;

// Get current date
DateTime today = DateTime.Now;

try
{
    string url = $"https://api.coingecko.com/api/v3/coins/markets?vs_currency={targetCurrency.ToString().ToLower()}&order=market_cap_desc&per_page=10&page=1&sparkline=false";

    HttpResponseMessage response = await client.GetAsync(url);

    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();

    // Console.WriteLine($"Response: {responseBody}");

    var options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        WriteIndented = true
    };

    var coins = JsonSerializer.Deserialize<List<Coin>>(responseBody, options) ?? new List<Coin>();

    foreach (var coin in coins)
    {
        if (coin.Id == "bitcoin")
        {
            Console.WriteLine($"Current Date: {today}");
            Console.WriteLine($"Coin ID: {coin.Id}, Name: {coin.Name}, Last Updated: {coin.LastUpdated.ToString("MMMM dd, yyyy hh:mm tt")}");
            Console.WriteLine("------------------------------");
            string jsonString = JsonSerializer.Serialize(coin, options);
            Console.WriteLine(jsonString);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

/*
Coin ID: bitcoin, Name: Bitcoin, Last Updated: 5/30/2026 6:23:43 PM
------------------------------
{
  "id": "bitcoin",
  "symbol": "btc",
  "name": "Bitcoin",
  "image": "https://coin-images.coingecko.com/coins/images/1/large/bitcoin.png?1696501400",
  "current_price": 73957,
  "market_cap": 1482287335177,
  "market_cap_rank": 1,
  "fully_diluted_valuation": 1482287335177,
  "total_volume": 20627168710,
  "high24h": null,
  "low24h": null,
  "price_change24h": null,
  "price_change_percentage24h": null,
  "market_cap_change24h": null,
  "market_cap_change_percentage24h": null,
  "circulating_supply": 20036643.0,
  "total_supply": 20036643.0,
  "max_supply": 21000000.0,
  "ath": 126080,
  "ath_change_percentage": -41.34086,
  "ath_date": "2025-10-06T18:57:42.558Z",
  "atl": 67.81,
  "atl_change_percentage": 108967.20471,
  "atl_date": "2013-07-06T00:00:00Z",
  "roi": null,
  "last_updated": "2026-05-30T18:23:43.735Z",
  "market_cap_rank_with_rehypothecated": 0
}
*/