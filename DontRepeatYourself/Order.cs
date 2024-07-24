namespace DontRepeatYourself;

public class Order
{
  public List<OrderItem> Items { get; set; } = [];

  public decimal Discount { get; set; }
}
