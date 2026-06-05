using System.Text.Json.Serialization;
namespace CoinGeckoAPI;

public class Coin
{
    // property initializes to its default value: "" is overwritten by the actual value
    public string Id { get; set; } = string.Empty;
    public string Symbol { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    public decimal CurrentPrice { get; set; }
    public decimal MarketCap { get; set; }
    public decimal Ath { get; set; }
    public decimal AthChangePercentage { get; set; }
    public decimal Atl { get; set; }
    public decimal AtlChangePercentage { get; set; }

    public int MarketCapRank { get; set; }
    public int MarketCapRankWithRehypothecated { get; set; }

    public DateTime AthDate { get; set; }
    public DateTime AtlDate { get; set; }
    public DateTime LastUpdated { get; set; }

    // Use of nullable value type modifiers for optional data
    public decimal? FullyDilutedValuation { get; set; }
    public decimal? TotalVolume { get; set; }
    public decimal? High24h { get; set; }
    public decimal? Low24h { get; set; }
    public decimal? PriceChange24h { get; set; }
    public decimal? PriceChangePercentage24h { get; set; }
    public decimal? MarketCapChange24h { get; set; }
    public decimal? MarketCapChangePercentage24h { get; set; }
    public decimal? CirculatingSupply { get; set; }
    public decimal? TotalSupply { get; set; }
    public decimal? MaxSupply { get; set; }

    // Nullable Reference Type
    public object? Roi { get; set; }

    // no constructor needed - just deserializing data from an API (DTO)
}

