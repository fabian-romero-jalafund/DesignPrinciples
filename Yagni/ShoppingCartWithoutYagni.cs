namespace Yagni;

public class ShoppingCartWithoutYagni
{
    private List<Item> items;

    public ShoppingCartWithoutYagni(){
        items = [];
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    // Anticipated functionality to apply discounts
    public decimal ApplyDiscount(decimal total, decimal discountPercentage)
    {
        return total - (total * discountPercentage / 100);
    }

    // Anticipated functionality to calculate taxes
    public decimal CalculateTax(decimal total, decimal taxRate)
    {
        return total + (total * taxRate / 100);
    }

    // Anticipated functionality to handle different currencies
    public decimal ConvertCurrency(decimal total, decimal conversionRate)
    {
        return total * conversionRate;
    }

    public decimal GetTotal()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price * item.Quantity;
        }

        // Unnecesary or non-required methods implemented:
        total = ApplyDiscount(total, 10);
        total = CalculateTax(total, 5); 
        total = ConvertCurrency(total, 1.2m);

        return total;
    }
}
