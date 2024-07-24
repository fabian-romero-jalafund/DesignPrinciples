namespace Yagni;

public class ShoppingCartWithYagni
{
    private List<Item> items;
    public ShoppingCartWithYagni()
    {
        items = [];
    }
    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public decimal GetTotal()
    {
        // Only required functionality
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price * item.Quantity;
        }

        return total;
    }
}
