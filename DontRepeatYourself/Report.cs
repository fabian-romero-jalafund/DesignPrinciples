namespace DontRepeatYourself;

public class Report
{
  public List<Order> Orders { get; set; } = [];

  public void GenerateReport()
  {
    foreach (var order in Orders)
    {
      decimal total = OrderCalculator.CalculateTotal(order);
      
      Console.WriteLine($"Order Total: {total:C}");
    }
  }
}
