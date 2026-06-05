# CoinGecko API

A simple C# project using the coingecko API, enums, HttpClient, DateTime, JsonSerializer.Deserialize and JsonSerializer.Serialize.

<!--
  namespace: CoinGeckoAPI
  GitHub slug: csharp-coingecko-api
  About text: ?
 -->

<span aria-hidden="true"><br></span>

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/) with [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

## Installation & Usage

1. Clone this repository and switch into project folder

   ```sh
   git clone https://github.com/Kernix13/csharp-coingecko-api.git CoinGeckoAPI
   cd CoinGeckoAPI
   ```

2. Run the application

   ```bash
   dotnet run
   ```

3. Build the application

   ```bash
   dotnet build
   ```

### <span aria-hidden="true">⚡</span> Quick Start

```sh
git clone https://github.com/Kernix13/csharp-coingecko-api.git CoinGeckoAPI
cd CoinGeckoAPI
dotnet run
```

<span aria-hidden="true"><br></span>

## Syntax used in this project

In Coins.cs:

1. public class
1. public properties
1. DateTime type
1. Nullable value type modifiers (`?`)

In Currency.cs:

1. public enum

In Program.cs:

1. HttpClient
   - DefaultRequestHeaders + Add: I was getting a 403 error from coingecko, this fixed it
   - HttpResponseMessage -> await GetAsync
   - EnsureSuccessStatusCode
   - Content.ReadAsStringAsync
2. Access Currency enum to set the currency in the endpoint
3. try/catch for API call
4. JsonSerializerOptions
   - JsonNamingPolicy > SnakeCaseLower, WriteIndented
5. JsonSerializer.Deserialize
6. new List
7. foreach
8. ex.Message
9. ToString
10. JsonSerializer.Serialize

### Requirements for this project

1. Use `List<T>` to manage arrays of data returned by the API
   - See the class in `Coin.cs` and the `coin` variable in `Program.cs` line 31.
2. Use `DateTime` when deserializing date and time values returned by the API
   - See `Coin.cs` for the 3 `DateTime` properties and line 11 in `Program.cs`
3. If constants are being returned by the API, deal with them as Enums as opposed to just string or integer values
   - NO CONSTANTS RETURNED - see example API object response below
   - If your web API does not return ...Enum values, just make sure to use them in your application
   - See `enum` in `Currency.cs` and its use in `Program.cs` line 8

### coingecko response object

- No arrays/lists
- Only strings, decimals, ints, datetime and 1 object (`Roi`)

```json
{
  "id": "bitcoin",
  "symbol": "btc",
  "name": "Bitcoin",
  "image": "https://coin-images.coingecko.com/coins/images/1/large/bitcoin.png?1696501400",
  "current_price": 63284,
  "market_cap": 1267868367992,
  "market_cap_rank": 1,
  "fully_diluted_valuation": 1267868367992,
  "total_volume": 66737105144,
  "high_24h": 65111,
  "low_24h": 61557,
  "price_change_24h": -1826.51990526,
  "price_change_percentage_24h": -2.80525,
  "market_cap_change_24h": -35801556992.7241,
  "market_cap_change_percentage_24h": -2.74621,
  "circulating_supply": 20038703,
  "total_supply": 20038703,
  "max_supply": 21000000,
  "ath": 126080,
  "ath_change_percentage": -49.80627,
  "ath_date": "2025-10-06T18:57:42.558Z",
  "atl": 67.81,
  "atl_change_percentage": 93227.13395,
  "atl_date": "2013-07-06T00:00:00.000Z",
  "roi": null,
  "last_updated": "2026-06-04T22:33:47.580Z"
},
```

<span aria-hidden="true"><br></span>

## Program.cs output

<!-- Coin ID: bitcoin, Name: Bitcoin, Last Updated: 5/30/2026 6:23:43 PM -->

```
Current Date: 6/5/2026 8:47:16 AM
Coin ID: bitcoin, Name: Bitcoin, Last Updated: June 05, 2026 12:46 PM
------------------------------
{
  "id": "bitcoin",
  "symbol": "btc",
  "name": "Bitcoin",
  "image": "https://coin-images.coingecko.com/coins/images/1/large/bitcoin.png?1696501400",
  "current_price": 61936,
  "market_cap": 1240789293227,
  "ath": 126080,
  "ath_change_percentage": -50.87543,
  "atl": 67.81,
  "atl_change_percentage": 91239.20439,
  "market_cap_rank": 1,
  "market_cap_rank_with_rehypothecated": 0,
  "ath_date": "2025-10-06T18:57:42.558Z",
  "atl_date": "2013-07-06T00:00:00Z",
  "last_updated": "2026-06-05T12:46:23.284Z",
  "fully_diluted_valuation": 1240789293227,
  "total_volume": 52926679940,
  "high24h": null,
  "low24h": null,
  "price_change24h": null,
  "price_change_percentage24h": null,
  "market_cap_change24h": null,
  "market_cap_change_percentage24h": null,
  "circulating_supply": 20038918.0,
  "total_supply": 20038918.0,
  "max_supply": 21000000.0,
  "roi": null
}
```

- Enum.TryParse if I use ReadLine for currency

<!-- ```json
[
  {
    "id": "bitcoin",
    "symbol": "btc",
    "name": "Bitcoin",
    "image": "<https://assets.coingecko.com/coins/images/1/large/bitcoin.png?1696501400>",
    "current_price": 70187,
    "market_cap": 1381651251183,
    "market_cap_rank": 1,
    "fully_diluted_valuation": 1474623675796,
    "total_volume": 20154184933,
    "high_24h": 70215,
    "low_24h": 68060,
    "price_change_24h": 2126.88,
    "price_change_percentage_24h": 3.12502,
    "market_cap_change_24h": 44287678051,
    "market_cap_change_percentage_24h": 3.31157,
    "circulating_supply": 19675987,
    "total_supply": 21000000,
    "max_supply": 21000000,
    "ath": 73738,
    "ath_change_percentage": -4.77063,
    "ath_date": "2024-03-14T07:10:36.635Z",
    "atl": 67.81,
    "atl_change_percentage": 103455.83335,
    "atl_date": "2013-07-06T00:00:00.000Z",
    "roi": null,
    "last_updated": "2024-04-07T16:49:31.736Z",
    "market_cap_rank_with_rehypothecated": 1
  }
]
``` -->

<span aria-hidden="true"><br></span>

## Important week 2 code and notes (IMO)

### 1. Get started with dates, times, and time zones

- `DateOnly`: Use this class when you need to work with dates without considering the time of day, such as setting event dates.
- `TimeOnly`: Ideal for scenarios where only the time is relevant, like scheduling daily sessions.
- `DateTime`: The most versatile structure, combining both date and time, suitable for general scheduling tasks.
- `DateTimeOffset`: Essential for applications that need to account for different time zones, as it includes an offset from UTC.
  - Use to log transaction times, system/app events, file creation and modification times
- `TimeZoneInfo`: Allows conversion of times between different time zones, ensuring accurate scheduling.
  - Use to convert times between different time zones
- `TimeSpan`: Represents durations or intervals, useful for calculating the length of events or breaks - methods for adding, subtracting, and comparing time intervals
  - Use to calculate the difference between two `DateTime` values or to measure elapsed time with the `Stopwatch.Elapsed` property
- The `Calendar` class represents time in divisions such as weeks, months, and years.

```cs
DayOfWeek today = DateTime.Now.DayOfWeek;
Console.WriteLine($"Today is: {today}"); // Today is: [DayOfWeek]

TimeSpan duration = new TimeSpan(2, 0, 0);
Console.WriteLine($"Event Duration: {duration}"); // Event Duration: 02:00:00

// Get the current date and time with offset
DateTimeOffset now = DateTimeOffset.Now;
Console.WriteLine($"Current date and time with offset: {now}");

// Get the number of days in February 2023
int daysInMonth = calendar.GetDaysInMonth(2023, 2);
Console.WriteLine("Days in February 2023: " + daysInMonth);

DateTime date = new DateTime(2023, 12, 31);
```

Skip: DayOfWeek, CultureInfo, CalendarWeekRule

### 2. Implement collection types

Collections are strongly typed - they store elements of a specific type (`T`)

- `List<T>`: access elements by index, dynamic resizing (add/remove)
  - Avoid using `List<T>` in public APIs
  - Add, Remove, RemoveAt, Length, Clear, Equals, Exists, Find, FindAll, FindIndex, ForEach, GetType, IndexOf, Insert, Reverse, Sort, ToArray, Trim
  - use a `foreach` loop or LINQ
- `HashSet<T>`: collections of unique elements (no duplicates)
  - unique and _unordered_
  - can grow in size
  - A HashSet is ~ a Dictionary without the values - just the keys
  - If you ingest data from an API or a CSV file that has duplicate records, dumping them into a HashSet cleans the data instantly
- `Dictionary<TKey, TValue>`: enables quick look-up by key (key: value)
  - Keys must be unique. Values can be of any type
  - access a key value using square bracket notation: `DictName[key]`
  - See [Dictionary Class Details](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2) for code blocks, properties, ...

```cs
/* List<T> */
List<Student> students = new List<Student> {
    new Student { Name = "Fred", Age = 20 },
    new Student { Name = "Ralph", Age = 22 }
};
// add a student, remove a student
students.Add(new Student { Name = "Dale", Age = 23 });
students.RemoveAt(0);
// loop thru List
foreach (Student student in students) {
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
}

/* HashSet<T> */
HashSet<string> names = new HashSet<string>();
names.Add("Fred");
names.Add("Ralph");
names.Add("Mia");
names.Add("Mia"); // Duplicate, won't be added

if (names.Contains("Fred")) {
    Console.WriteLine("Fred is in the collection.");
}
foreach (string name in names) {
    Console.WriteLine(name);
}

/* Dictionary<TKey, TValue> */
var students = new Dictionary<int, string>
{
    { 101, "Ji-min Jo" },
    { 102, "Catalina Blaga" }
};
// add key: value record
students.Add(103, "Milan Golob"); // Add a new key-value pair
// loop thru using in keyword
foreach (var kvp in students) {
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
```

### 3. Implement enum, struct, and record types

- Use `enums` in C# to define named constants - are ideal for representing a set of predefined values
  - help prevent invalid values from being assigned, as only the defined constants are allowed
  - the underlying type of an `enum` is `int`, and the values start at `0`, incrementing by 1 for each member
- `record`: model data that shouldn't change after creation - provide a way to create immutable data models with value-based equality
  - To define an immutable data model
  - Records automatically generate properties, constructors, and methods like ToString, Equals, and GetHashCode
  - Records are useful for scenarios like modeling API responses, configuration settings, or logging events
  - Record classes support inheritance, enabling you to create hierarchies while maintaining immutability and value-based equality

```cs
// enum examples
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}

public enum FileMode {
    CreateNew = 1,
    Create = 2,
    Open = 3,
    OpenOrCreate = 4,
    Truncate = 5,
    Append = 6,
}

// Use positional syntax to define records
public record Point(int X, int Y);

var point = new Point(3, 4);
Console.WriteLine(point); // Output: Point { X = 3, Y = 4 }

// Apply inheritance with records (?)
public record Animal(string Name);
public record Dog(string Name, string Breed) : Animal(Name);

var dog = new Dog("Buddy", "Amstaff");
Console.WriteLine(dog); // Output: Dog { Name = Buddy, Breed = Amstaff }
```

<span aria-hidden="true"><br></span>

## Code not included/skipped

- struct
- Generics
- anonymous types
- `Guid.NewGuid()`

> [!NOTE]
> I may revisit Generics & anonymous types when working with LINQ.
