namespace EncapsulationPrinciple;

public class BankAccount
{
  private decimal _balance;

  public string AccountNumber { get; set; }
  
  public string Owner { get; set; }

  public decimal Balance { get => _balance; }

  public BankAccount() 
  {
    _balance = 0;
  }

  public void Deposit(decimal amount)
  {
    _balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    _balance -= amount;
  }
}
