using ReqnrollQuickstart.App;

var calculator = new PriceCalculator();

var basket = new Dictionary<string, int>
{
    { "Electric guitar", 1 },
    { "Guitar pick", 10 }
};

var total = calculator.CalculatePrice(basket);

Console.WriteLine("Shopping Basket:");
foreach (var item in basket)
{
    Console.WriteLine($"  {item.Value}x {item.Key}");
}
Console.WriteLine($"\nTotal: ${total}");
