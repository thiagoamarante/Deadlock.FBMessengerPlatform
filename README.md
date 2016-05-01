# Deadlock.FBMessengerPlatform (1.0.0)

Framework in C # to create bots for Facebook Messenger Platform

C# Framework to make trades with the private [Robinhood](https://www.robinhood.com/) API. 
Using this API is not encouraged, since it's not officially available. 

> This framework was inspired by a deprecated Python framework originally developed by [@Rohanpai](https://github.com/rohanpai).

> Disclaimer: This is an unofficial client package.
I'm not affiliated with the folks at Robinhood Markets Inc.



## Features
      
* Login
* Get User
* Get Accounts
* Get Positions
* Get Portfolio
* Get Orders
* New Order
* Cancel Order
* Get Instrument
* Get Quote


```c#

using Deadlock.Robinhood;

static string _token = "";
static string _account = "";
static string _username = "";
static string _password = "";
static string _instrumentTwitter = "https://api.robinhood.com/instruments/3a47ca97-d5a2-4a55-9045-053a588894de/";
static string _orderId = "";
```

### Login with username and password

```c#

static async Task Login()
{
    using (RobinhoodClient client = new RobinhoodClient())
    {
        var result = await client.Login(_username, _password);
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(result.Data.Token);
        }
    }
}
```

### Login with token

```c#

static async Task LoginWithToken()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Quote("TWTR");
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(result.Data.Symbol);
        }
    }
}
```

### Get user informations

```c#

static async Task GetUserInformations()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.User();
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(result.Data.Username);
        }
    }
}
```

### List Accounts

```c#

static async Task ListAccounts()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Accounts();
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            result.Data.Results.ForEach(account =>
                Console.WriteLine(account.AccountNumber)
            );
        }
    }
}
```

### List Positions

```c#

static async Task ListPositions()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Positions();
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            result.Data.Results.ForEach(position =>
                Console.WriteLine(position.Quantity)
            );
        }
    }
}
```

### Get Portfolio

```c#

static async Task GetPortfolio()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var resultPortfolios = await client.Portfolios();
        if (resultPortfolios.StatusCode == System.Net.HttpStatusCode.OK)
        {
            resultPortfolios.Data.Results.ForEach(portfolio =>
                Console.WriteLine(portfolio.MarketValue)
            );
        }

        //by accountNumber
        var resultPortfolio = await client.Portfolios(UrlManager.GetAccountNumber(_account));
        if (resultPortfolio.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(resultPortfolio.Data.MarketValue);
        }
    }
}
```

### List Orders

```c#

static async Task ListOrders()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Orders();
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            result.Data.Results.ForEach(order =>
                Console.WriteLine(order.Price)
            );
        }
    }
}
```

### New Order

```c#

static async Task NewOrder()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Orders(new Model.NewOrder()
        {
            Account = _account,                 
            Price = 10,
            Quantity = 1,
            Side = Model.Side.Buy,
            TimeInForce = "gfd",
            Trigger = "immediate",
            Type = "market",
            Symbol = "TWTR",
            Instrument = _instrumentTwitter
        });
        if (result.IsSuccessStatusCode)
        {
            _orderId = result.Data.Id;
        }
    }
}
```

### Cancel Order

```c#

static async Task CancelOrder()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.CancelOrder(_orderId);
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {

        }
    }
}
```

### Get Instrument

```c#

static async Task GetInstrument()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Instrument("3a47ca97-d5a2-4a55-9045-053a588894de"); //twitter
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(result.Data.Name);
        }
    }
}
```

### Get Quote

```c#

static async Task GetQuote()
{
    using (RobinhoodClient client = new RobinhoodClient(_token))
    {
        var result = await client.Quote("TWTR");
        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine(result.Data.BidPrice);
        }
    }
}
```